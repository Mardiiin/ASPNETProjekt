using System;
using System.Collections.Generic;
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
    [Authorize(Roles = "Admin")]
    public class ManageUsersModel : PageModel
    {
        
        private readonly UserManager<User> _userManager;
        private readonly InlämningContext _context;



        public ManageUsersModel( UserManager<User> userManager, InlämningContext context)
        {
          
            _userManager = userManager;
            _context = context;
           
        }

        [BindProperty]
        public IList<User> Organizer { get; set; }

        public IList<User> Attendee { get; set; }
        [BindProperty]
        public string userx { get; set; } 


        public async Task OnGetAsync()
        {

            Attendee = await _userManager.GetUsersInRoleAsync("Attendee");
            Organizer = await _userManager.GetUsersInRoleAsync("Organizer");


        }


        public async Task<IActionResult> OnPostAsync(IdentityUser<string> user)
        {
        
            Attendee = await _userManager.GetUsersInRoleAsync("Attendee");
            Organizer = await _userManager.GetUsersInRoleAsync("Organizer");

            var userx = await _userManager.FindByIdAsync(user.Id);
            
            if (await _userManager.IsInRoleAsync(userx, ("Organizer")))
            {

                await _userManager.RemoveFromRoleAsync(userx, "Organizer");
                await _userManager.AddToRoleAsync(userx, "Attendee");

                return RedirectToPage("/Admin/ManageUsers");
            }
            else if (await _userManager.IsInRoleAsync(userx, ("Attendee")))
            {

                await _userManager.RemoveFromRoleAsync(userx, "Attendee");
                await _userManager.AddToRoleAsync(userx, "Organizer");

                return RedirectToPage("/Admin/ManageUsers");


            }
            else 
            {
                return RedirectToPage("/Admin/ManageUsers");
            }

        }

    }
    


}

