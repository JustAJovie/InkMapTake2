using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InkMapAPI.Models
{
    public class Customers
    {
        //public int Customer_ID;
        public String customer_FirstName;
        public String customer_LastName;
        public String cust_email;
        public String cust_phoneNumber;
        //public int Account_ID;

        public String Cust_FirstName
        {
            get { return customer_FirstName; }
            set { customer_FirstName = value; }
        }

        public String Cust_LastName
        {
            get { return customer_LastName; }
            set { customer_LastName = value; }
        }
        public String Cust_Email
        {
            get { return cust_email; }
            set { cust_email = value; }
        }
        public String Cust_PhoneNumber
        {
            get { return cust_phoneNumber; }
            set { cust_phoneNumber = value; }
        }



    }
}
