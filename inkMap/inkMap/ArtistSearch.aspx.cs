using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace inkMap
{
    public partial class ArtistSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLocationSearch_Click(object sender, EventArgs e)
        {
            NewAccountService.NewAccount proxy = new NewAccountService.NewAccount();

            NewAccountService.Artist artist = proxy.GetArtistByZip(txtLocationArtist.Text);

            if(artist != null)
            {
                lblArtistFName.Text = artist.artist_FName;
                lblArtistLName.Text = artist.artist_LName;
                lblCompany.Text = artist.company;
                lblCity.Text = artist.city;
                lblState.Text = artist.state;
            }
            else
            {
                lblArtistFName.Text = "Nothing.";
            }

        }
    }
}