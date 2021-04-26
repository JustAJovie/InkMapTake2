using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Security.Cryptography;     // needed for the encryption classes
using System.IO;                        // needed for the MemoryStream
using System.Text;                      // needed for the UTF8 encoding
using System.Net;                       // needed for the cookie
using InkMapLibrary;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using Utilities;


namespace inkMap
{
    public partial class Default : System.Web.UI.Page
    {
        private Byte[] key = { 250, 101, 18, 76, 45, 135, 207, 118, 4, 171, 3, 168, 202, 241, 37, 199 };
        private Byte[] vector = { 146, 64, 191, 111, 23, 3, 113, 119, 231, 121, 252, 112, 79, 32, 114, 156 };

        dbProcedures procedure = new dbProcedures();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["Login"] != null)
            {
                HttpCookie cookie = Request.Cookies["Login"];
                String encryptedPassword = cookie.Values["Password"];

                Byte[] encryptedPasswordBytes = Convert.FromBase64String(encryptedPassword);
                Byte[] textBytes;
                String plainTextPassword;

                UTF8Encoding encoder = new UTF8Encoding();

                // Perform Decryption
                //-------------------
                // Create an instances of the decryption algorithm (Rinjdael AES) for the encryption to perform,
                // a memory stream used to store the decrypted data temporarily, and
                // a crypto stream that performs the decryption algorithm.
                RijndaelManaged rmEncryption = new RijndaelManaged();
                MemoryStream myMemoryStream = new MemoryStream();
                CryptoStream myDecryptionStream = new CryptoStream(myMemoryStream, rmEncryption.CreateDecryptor(key, vector), CryptoStreamMode.Write);

                // Use the crypto stream to perform the decryption on the encrypted data in the byte array.
                myDecryptionStream.Write(encryptedPasswordBytes, 0, encryptedPasswordBytes.Length);
                myDecryptionStream.FlushFinalBlock();

                // Retrieve the decrypted data from the memory stream, and write it to a separate byte array.
                myMemoryStream.Position = 0;
                textBytes = new Byte[myMemoryStream.Length];
                myMemoryStream.Read(textBytes, 0, textBytes.Length);

                // Close all the streams.
                myDecryptionStream.Close();
                myMemoryStream.Close();

                // Convert the bytes to a string and display it.
                plainTextPassword = encoder.GetString(textBytes);
                txtEmail.Text = cookie.Values["UserName"].ToString();
                txtPass.Text = plainTextPassword;

                

                
            }
            

        }
        protected void saveLogIn_Click(object sender, EventArgs e)
        {
            String username = txtEmail.Text;
            String plainTextPwd = txtPass.Text;
            String encryptPwd;

            UTF8Encoding encoder = new UTF8Encoding();
            Byte[] txtBytes;

            //Converts string to byte array
            txtBytes = encoder.GetBytes(plainTextPwd);

            Rijndael rmEncrpytion = new RijndaelManaged();
            MemoryStream memStream = new MemoryStream();
            CryptoStream encryptStream = new CryptoStream(memStream, rmEncrpytion.CreateEncryptor(key, vector), CryptoStreamMode.Write);

            //Use crypto stream to encrypt on plain text byte array
            encryptStream.Write(txtBytes, 0, txtBytes.Length);
            encryptStream.FlushFinalBlock();

            //Retrieve encrypt data from memory stream and write to separate byte array
            memStream.Position = 0;
            Byte[] encryptBytes = new Byte[memStream.Length];
            memStream.Read(encryptBytes, 0, encryptBytes.Length);

            //Close all streams
            encryptStream.Close();
            memStream.Close();

            encryptPwd = Convert.ToBase64String(encryptBytes);

            HttpCookie cookye = new HttpCookie("Login");
            cookye.Values["UserName"] = username;
            cookye.Values["Password"] = encryptPwd;
            cookye.Expires = new DateTime(2099, 1, 1);
            Response.Cookies.Add(cookye);

            lblStoreName.Text = "Username has been stored!";

        }
        protected void deleteLogIn_Click(object sender, EventArgs e)
        {
           if(Request.Cookies["Login"] != null)
            {
                Response.Cookies["Login"].Expires = DateTime.Now.AddDays(-1);
            }

            lblStoreName.Text = "Username has been deleted!";
            txtEmail.Text = " ";
            txtPass.Text = " ";
        }

        public void NewAccount (Account account)
        {
            NewAccountService.Account AccountInfo = new NewAccountService.Account();

            AccountInfo.password = account.password;
            AccountInfo.accountType = account.accountType;
            AccountInfo.firstName = account.firstName;
            AccountInfo.lastName = account.lastName;
            AccountInfo.email = account.email;
            AccountInfo.phoneNumber = account.phoneNumber;

            NewAccountService.NewAccount proxy = new NewAccountService.NewAccount();

            if (proxy.AddAccount(AccountInfo))
            {
                lblStoreName.Text = "Account was created successfully!";

            }
            else
            {
                lblStoreName.Text = "Account was not created D:";

            }

        }

        protected void lbtnCreateAccountCustomer_Click(object sender, EventArgs e)
        {

            Account custAccount = new Account();
            custAccount.password = txtConfirmPass.Text;
            custAccount.accountType = "customer";
            custAccount.firstName = txtCustomerFName.Text;
            custAccount.lastName = txtCustomerLName.Text;
            custAccount.email = txtCustomerEmail.Text;
            custAccount.phoneNumber = txtCustomerPhone.Text;

            NewAccount(custAccount);

            NewAccountService.Account customer = new NewAccountService.Account();

            customer.firstName = txtCustomerFName.Text;
            customer.lastName = txtCustomerLName.Text;
            customer.email = txtCustomerEmail.Text;
            customer.phoneNumber = txtCustomerPhone.Text;


            NewAccountService.NewAccount proxy = new NewAccountService.NewAccount();

            if (proxy.AddCustomer(customer))
            {
                DataSet userData = procedure.getaccountidfromemail(txtCustomerEmail.Text);
                Email verificationEmail = new Email();
                string receiveremail = txtCustomerEmail.Text;
                string senderEmail = "verify@inkmap.com";
                string subject = "Verify your account";
                int account = int.Parse(userData.Tables[0].Rows[0]["Account_ID"].ToString());

                string body = "Please refer to this URL to confirm your account creation. http://localhost:63822/verification.aspx?ID=" + account;
                verificationEmail.SendMail(receiveremail, senderEmail, subject, body);

                lblStoreName.Text = "Customer Account was created successfully!";

            }
            else
            {
                lblStoreName.Text = "Account was not created D:";

            }


        }

        protected void lbtnCreateAccountArtist_Click(object sender, EventArgs e)
        {
            Account artType = new Account();
            artType.password = txtArtistConfirm.Text;
            artType.accountType = "artist";
            artType.firstName = txtArtistFName.Text;
            artType.lastName = txtArtistLName.Text;
            artType.email = txtArtistEmail.Text;
            artType.PhoneNumber = txtArtistPhone.Text;

            NewAccount(artType);

            NewAccountService.Artist artist = new NewAccountService.Artist();

            artist.artist_FName = txtArtistFName.Text;
            artist.artist_LName = txtArtistLName.Text;
            artist.email = txtArtistEmail.Text;
            artist.phoneNumber = txtArtistPhone.Text;
            artist.company = txtArtistCompany.Text;
            artist.rating = Convert.ToDecimal("0.0");
            artist.certification = txtArtistCert.Text;
            artist.city = txtArtistCity.Text;
            artist.state = txtArtistState.Text;
            artist.zipcode= txtArtistZipcode.Text;
            artist.streetAddress = txtArtistStreetAddress.Text;
            artist.address2 = txtArtistAddress2.Text;

            NewAccountService.NewAccount proxy = new NewAccountService.NewAccount();

            if (proxy.AddArtist(artist))
            {
                lblStoreName.Text = "Artist Account was created successfully!";

            }
            else
            {
                lblStoreName.Text = "Account was not created D:";

            }


        }


    }
}