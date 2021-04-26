using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InkMapLibrary
{
    public class Artist
    {
        //public int Account_ID;
        public String artist_FName;
        public String artist_LName;
        public String email;
        public String phoneNumber;
        public String company;
        public Decimal rating;
        public String certification;
        public String city;
        public String state;
        public String zipcode;
        public String streetAddress;
        public String address2;
        public int artist_ID;

        public String Artist_FName
        {
            get { return artist_FName; }
            set { artist_FName = value; }
        }
        public String Artist_LName
        {
            get { return artist_LName; }
            set { artist_LName = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public String Company
        {
            get { return company; }
            set { company = value; }
        }
        public Decimal Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public String Certification
        {
            get { return certification; }
            set { certification = value; }
        }
        public String City
        {
            get { return city; }
            set { city = value; }
        }
        public String State
        {
            get { return state; }
            set { state = value; }
        }
        public String Zipcode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }
        public String StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }
        public String Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        public int Artist_ID
        {
            get { return artist_ID; }
            set { artist_ID = value; }
        }

    }
}