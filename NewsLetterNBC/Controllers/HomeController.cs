using NewsLetterNBC.Models;
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
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))

            {
                return View("~/View/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;


                    db.Signups.Add(signup);
                    db.SaveChanges();
                }

                return View("Success");
            }
        }

            public ActionResult Adim()
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signups = db.Signups;
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
    }

            