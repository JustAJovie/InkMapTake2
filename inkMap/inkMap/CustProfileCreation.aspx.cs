using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Utilities;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using InkMapLibrary;

namespace inkMap
{
    public partial class CustProfileCreation : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        dbProcedures procedure = new dbProcedures();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)
            {
                int accountid = int.Parse(Request.QueryString["ID"]);
                DataSet userData = procedure.getcustomerinfo(accountid);

              //Tables[0].Rows[0]["Verification"].ToString();

                lblPrintFname.Text = userData.Tables[0].Rows[0]["Customer_FirstName"].ToString();
                lblPrintLname.Text = userData.Tables[0].Rows[0]["Customer_LastName"].ToString();
                lblPrintEmail.Text = userData.Tables[0].Rows[0]["Email"].ToString();
                lblPrintPhone.Text = userData.Tables[0].Rows[0]["PhoneNumber"].ToString();
            }
            else
            {

            }

        }

        protected void lbtnEnterSite_Click(object sender, EventArgs e)
        {
            int accountid = int.Parse(Request.QueryString["ID"]);
            int imageSize;
            string fileExtension;
            string imgType;
            string imgName; 
            
            try
            {
                if (uploadProfilePic.HasFile)
                {
                    imageSize = uploadProfilePic.PostedFile.ContentLength;
                    byte[] imageData = new byte[imageSize];

                    uploadProfilePic.PostedFile.InputStream.Read(imageData, 0, imageSize);
                    imgName = uploadProfilePic.PostedFile.FileName;
                    imgType = uploadProfilePic.PostedFile.ContentType;

                    fileExtension = imgName.Substring(imgName.LastIndexOf("."));
                    fileExtension = fileExtension.ToLower(); 

                    if(fileExtension ==".jpg" || fileExtension ==".jpeg" || fileExtension == ".png")
                    {
                        int updateDB = procedure.updateProfileImage(accountid, imgName, imgType, imageData, imageData.Length);
                    }
                    else
                    {
                        Response.Write("<script>alert('This site does not accept the file type you uploaded. Please submit a .jpg, .jpeg or .png file.')</script>");

                    }


                }
                Response.Redirect("CustomerLandingPage.aspx?ID=" + accountid);
            }catch{

            }
        }
    }
}