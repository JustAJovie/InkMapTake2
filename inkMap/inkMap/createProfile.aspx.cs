using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlClient;
using System.Data;
using Utilities;

namespace inkMap
{
    public partial class createProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUploadFile_Click(object sender, EventArgs e)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            int result = 0, imageSize;
            string fileExtension, imageType, imageTitle, strSQL;

            try
            {
                if (uploadProfileImage.HasFile)
                {
                    imageSize = uploadProfileImage.PostedFile.ContentLength;
                    byte[] imageData = new byte[imageSize];

                    uploadProfileImage.PostedFile.InputStream.Read(imageData, 0, imageSize);
                    imageTitle = uploadProfileImage.PostedFile.FileName;
                    imageType = uploadProfileImage.PostedFile.ContentType;

                    fileExtension = imageTitle.Substring(imageTitle.LastIndexOf("."));
                    fileExtension = fileExtension.ToLower();

                    if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif")
                    {
                        strSQL = "TP_UploadProfilePic";
                        objCommand.CommandText = strSQL;

                        objCommand.CommandType = CommandType.StoredProcedure;
                        objCommand.Parameters.AddWithValue("@accountid", 2);
                        objCommand.Parameters.AddWithValue("@title", imageTitle);
                        objCommand.Parameters.AddWithValue("@type", imageType);
                        objCommand.Parameters.AddWithValue("@data", imageData);
                        objCommand.Parameters.AddWithValue("@length", imageData.Length);
                        result = objDB.DoUpdateUsingCmdObj(objCommand);

                        lblStatus.Text = "Image was successully uploaded.";
                        Response.Redirect("viewProfile.aspx");
                    }
                    else
                    {
                        lblStatus.Text = "Only jpg, png, and gif file formats supported.";
                    }


                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error ocurred: [" + ex.Message + "] cmd=" + result;
            }
        }
    }
}