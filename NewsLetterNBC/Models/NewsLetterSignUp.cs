﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsLetterNBC.Models
{
    public class NewsLetterSignUp
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;  }
        public string SocialSecurityNumber { get; internal set; }
    }
}