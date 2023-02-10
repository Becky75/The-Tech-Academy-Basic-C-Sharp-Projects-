﻿using Microsoft.AspNetCore.Mvc.RazorPages;

namespace challenge_assignment.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string datetime = DateTime.Now.ToShortDateString();
            ViewData ["TimeStamp"] = datetime;
        }
    }
}