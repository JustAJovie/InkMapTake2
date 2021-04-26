using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InkMapAPI.Models
{
    public class Testimonial
    {
        public int artist_ID;
        public int cust_ID;
        public String title;
        public String body;

        public int Artist_ID
        {
            get { return artist_ID; }
            set { artist_ID = value; }
        }
        public int Cust_ID
        {
            get { return cust_ID; }
            set { cust_ID = value; }
        }
        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        public String Body
        {
            get { return body; }
            set { body = value; }
        }
    }
}