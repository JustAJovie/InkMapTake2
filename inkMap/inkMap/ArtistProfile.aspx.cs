using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Script.Serialization;
using System.IO;
using System.Net;
using InkMapLibrary;


namespace inkMap
{
    public partial class ArtistProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddTest_Click(object sender, EventArgs e)
        {
            Testimonial comment = new Testimonial();
            comment.artist_ID = Convert.ToInt32(txtArt.Text);
            comment.cust_ID = Convert.ToInt32(txtCust.Text);
            comment.title = txtTitle.Text;
            comment.body = txtBody.Text;


            JavaScriptSerializer js = new JavaScriptSerializer();
            String jsonComment = js.Serialize(comment);

            try
            {
                // Setup an HTTP POST Web Request and get the HTTP Web Response from the server.

                WebRequest request = WebRequest.Create("https://localhost:44344/api/Customer/SaveTestimonial");
                request.Method = "POST";
                request.ContentLength = jsonComment.Length;
                request.ContentType = "application/json";
                // Write the JSON data to the Web Request

                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write(jsonComment);
                writer.Flush();
                writer.Close();

                // Read the data from the Web Response, which requires working with streams.
                WebResponse response = request.GetResponse();
                Stream theDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(theDataStream);
                String data = reader.ReadToEnd();
                reader.Close();
                response.Close();

                if (data == "true")
                {
                    lblMessage.Text = "The testimony was successfully saved to the database.";
                }

                else
                {
                    lblMessage.Text = "The testimony wasn't saved to the database.";
                }
            }
            catch
            {
                lblMessage.Text = " no ork";
            }

        }
    }
}