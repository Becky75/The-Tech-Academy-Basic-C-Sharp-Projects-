﻿using NewsLetterNBC.Models;
using NewsLetterNBC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterNBC.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=THUNDERHOOF\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(string firstName, String lastName, String emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))

                {
                return View("~/View/Shared/Error.cshtml");
            }
            else
            {
                 
                string queryString = @"INSERT INTO signups (FirstName, LastName, EmailAddress) VALUES
                    (@FirstName, @LastName, @EmailAddress)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();


                }
                    return View("Success");
                
            }
        }

        public ActionResult Admin()
        {

            string queryString = @"SELECT Id, FirstName,LastName, EmailAddress, SocialSecurtyNumber from signups";
            List<NewsLetterSignUp> signups = new List<NewsLetterSignUp>();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
               
                while(reader.Read())
                        {
                    var signup = new NewsLetterSignUp();
                    signup.Id = Convert.ToInt32(reader["Id"]);
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.EmailAddress = reader["EmalAddress"].ToString();
                    signup.SocialSecurtyNumber = reader["SocialSecurtyNumber"].ToString();
                    
                    signups.Add(signup);

                }
            }
            var signupVms = new List<SignupVm>();
            foreach (var signup in signups)
            {
                var signupVm = new SignupVm();
                signupVm.FirstName = signup.FirstName;
                signupVm.LastName = signup.LastName;
                signupVm.EmailAddress = signup.EmailAddress;

                signupVms.Add(signupVm);
                    }
             
            return View(signupVms);
        }
    }
}