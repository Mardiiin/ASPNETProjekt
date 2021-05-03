using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inlämning.Data;
using Inlämning.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace Inlämning.Pages.Admin
{
    [Authorize(Roles = "Admin")]
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

   

        public IList<User> Attendee { get; set; }
        public IList<User> Organizer { get; set; }
        public IList<User> Admin { get; set; }

        public string Roles { get; set; }

        public async Task OnGetAsync()
        {

            Attendee  = await _userManager.GetUsersInRoleAsync("Attendee");
            Organizer = await _userManager.GetUsersInRoleAsync("Organizer");
            Admin     = await _userManager.GetUsersInRoleAsync("Admin");

        }
    }
}
