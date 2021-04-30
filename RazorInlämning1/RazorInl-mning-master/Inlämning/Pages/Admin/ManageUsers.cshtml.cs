using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Inlämning.Data;
using Inlämning.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inlämning.Pages.Admin
{
    public class ManageUsersModel : PageModel
    {
        private readonly InlämningContext _context;
        private readonly UserManager<User> _userManager;


        public ManageUsersModel(InlämningContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]

        public IList<User> _Users { get; set; }

        public void OnGet()
        {
            _Users =  _userManager.Users.ToList();
           
        }
    }
}
