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
	public partial class profileimagegrab : System.Web.UI.Page
	{

        DBConnect objDB = new DBConnect();
        dbProcedures procedure = new dbProcedures();
        protected void Page_Load(object sender, EventArgs e)
		{
            if(Request.QueryString["ID"] != null) {
            int accountid = int.Parse(Request.QueryString["ID"]);
            DataSet userImage = procedure.getprofileimage(accountid); 

            byte[] imgData = (byte[])userImage.Tables[0].Rows[0]["ImageData"];

            Response.Clear();
            Response.OutputStream.Write(imgData, 0, imgData.Length);
            //Response.BinaryWrite(imageData);

            Response.End();
            }
            else
            {
                Response.Write("<script>alert('You are trying to access an admin page. Please visit inkmap.com to get started')</script>");
            }
        }
    }
}