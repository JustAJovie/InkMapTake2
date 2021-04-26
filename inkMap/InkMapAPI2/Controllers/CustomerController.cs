using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Utilities;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using InkMapAPI.Models;
using InkMapLibrary;

namespace InkMapAPI.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        DBConnect dBConnect = new DBConnect();
        // GET: api/Customer
        [HttpGet]
        public List<Customers> GetAllCustomers()
        {
            List<Customers> CustomerList = new List<Customers>();
            DataSet customers = dBConnect.GetDataSet("SELECT * FROM TP_Customer");

            foreach (DataRow record in customers.Tables[0].Rows)
            {
                Customers customer = new Customers();
                customer.customer_FirstName = record["Customer_FirstName"].ToString();
                customer.customer_LastName = record["Customer_LastName"].ToString();
                customer.cust_email= record["Email"].ToString();
                customer.cust_phoneNumber = record["PhoneNumber"].ToString();

                CustomerList.Add(customer);
            }
            return CustomerList;
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        [HttpPost]
        public Boolean Post([FromBody] Testimonial comment)
        {

            DBConnect objDB = new DBConnect();
            SqlCommand addTestcmd = new SqlCommand();

            addTestcmd.CommandType = CommandType.StoredProcedure;
            addTestcmd.CommandText = "TP_AddTestimonial";

            addTestcmd.Parameters.AddWithValue("@artist_ID", comment.artist_ID);
            addTestcmd.Parameters.AddWithValue("@cust_ID", comment.cust_ID);
            addTestcmd.Parameters.AddWithValue("@title", comment.title);
            addTestcmd.Parameters.AddWithValue("@body", comment.body);

            int result = objDB.DoUpdateUsingCmdObj(addTestcmd);

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
