using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InkMapLibrary
{
    public class Account
    {
        //public int Account_ID;
        public String password;
        public String accountType;
        public String firstName;
        public String lastName;
        public String email;
        public String phoneNumber;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
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
    }
}