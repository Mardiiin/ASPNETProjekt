using Inlämning.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static Inlämning.Pages.RegisterModel;

namespace Inlämning.Pages
{
    
    public class IndexModel : PageModel
    {

        public string userName { get; set; }


        private readonly ILogger<IndexModel> _logger;
        private readonly UserManager<User> _userManager;

        public IndexModel(ILogger<IndexModel> logger, UserManager<User> UserManager)
        {
            _logger = logger;
            UserManager = _userManager;
        }



        public void OnGet()
        {
            userName = User.FindFirstValue(ClaimTypes.Name);

        }
    }
}
