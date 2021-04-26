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
    public partial class verification : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        dbProcedures procedure = new dbProcedures();

        protected void Page_Load(object sender, EventArgs e)
        {
          

            if (Request.QueryString["ID"] != null)
            {
                int accountid = int.Parse(Request.QueryString["ID"]);
                DataSet userData = procedure.getVerificationInformation(accountid);
                DataSet verificationStatus = procedure.getverification(accountid);
                int verifactionCode = int.Parse(verificationStatus.Tables[0].Rows[0]["Verification"].ToString());


                if (verifactionCode != 1)
                {
                    int updateStatus = procedure.updateAccountVerification(accountid);

                    if (updateStatus == 1)
                    {
                        string fName = userData.Tables[0].Rows[0]["FirstName"].ToString();
                        string lName = userData.Tables[0].Rows[0]["LastName"].ToString();
                        string accountName = fName + " " + lName;
                        lblVerificationTitle.Text = "Account has been verified";
                        lblVerificationInfo.Text = "Account for " + accountName + " has been verified. You are now able to access your information. Please click the button below to begin account set up.";
                        lbtnBackHome.Visible = false;
                    }
                    else
                    {
                        lblVerificationTitle.Text = "Something went wrong";
                        lblVerificationInfo.Text = "Your account was not verified. Please contect system admins.";
                        lbtnBeginSetUp.Text = "Log In";
                        lbtnBeginSetUp.Visible = false;
                    }

                }
                else
                {
                    lblVerificationTitle.Text = "Verification Not Valid";
                    lblVerificationInfo.Text = "Verification of this account has already been complete. Please click the link below to log in to your account.";
                    lbtnBeginSetUp.Text = "Log In";
                    lbtnBeginSetUp.Visible = false;
                }
            }
            else
            {
                lblVerificationTitle.Text = "ERROR";
                lblVerificationInfo.Text = "You did not enter the valid URL needed to verify your accout. Reminder that all verification links are sent to the email you used to sign up with us. Please check you email or contact an admin for help.";
                lbtnBeginSetUp.Visible = false;
            }


        }

        protected void lbtnBackHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx"); 
        }

        protected void lbtnBeginSetUp_Click(object sender, EventArgs e)
        {
            int accountid = int.Parse(Request.QueryString["ID"]);
            DataSet accountType = procedure.getaccounttype(accountid);
            string userType = accountType.Tables[0].Rows[0]["AccountType"].ToString();

            if(userType == "customer")
            {
                Response.Redirect("CustProfileCreation.aspx?ID="+accountid);
            }
        }
    }
}

