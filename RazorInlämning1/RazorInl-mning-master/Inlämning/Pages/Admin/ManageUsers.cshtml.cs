using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Inlämning.Data;
using Inlämning.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Inlämning.Pages.Admin
{
    [Authorize]
    public class ManageUsersModel : PageModel
    {
        
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly InlämningContext _context;

        public ManageUsersModel( UserManager<User> userManager, RoleManager<IdentityRole> roleManager, InlämningContext context)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [BindProperty]
        public IList<User> Users { get; set; }


        public  void OnGet()
        {
            Users = _userManager.Users.Include().ToList();
            



        }
    }
}
