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


        public IList<User> Organizer { get; set; }
        public IList<User> Attendee { get; set; }
        public bool x { get; set; } 


        public async Task OnGetAsync()
        {

            Attendee = await _userManager.GetUsersInRoleAsync("Attendee");
            Organizer = await _userManager.GetUsersInRoleAsync("Organizer");


        }


        public string Message { get; set; }


        public async Task <IActionResult> OnPostAsync(string user)
        
        {
            
                var userx = await _userManager.FindByIdAsync(user);

            if (await _userManager.IsInRoleAsync(userx, ("Organizer")))
            {

                await _userManager.RemoveFromRoleAsync(userx, "Organizer");
                await _userManager.AddToRoleAsync(userx, "Attendee");
                return Page();
            }
            else if (await _userManager.IsInRoleAsync(userx, ("Attendee")))
            {

                await _userManager.RemoveFromRoleAsync(userx, "Attendee");
                await _userManager.AddToRoleAsync(userx, "Organizer");

                return Page();


            }
            else
            {
                return Page();
            }

        }

    }
    


}

