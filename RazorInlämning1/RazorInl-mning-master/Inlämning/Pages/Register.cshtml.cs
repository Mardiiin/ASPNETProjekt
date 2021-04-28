using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inlämning.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inlämning.Pages
{
    public class RegisterModel : PageModel

    {
        
        private readonly UserManager<User> _UserManager;

        public RegisterModel(UserManager<User> UserInManager)
        {
            _UserManager = UserInManager;
            
        }


        [BindProperty]

        public NewUserForm  NewUser {get; set;}
        public class NewUserForm
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        public string Message { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {


            User newUser = new User()
            {
                UserName = NewUser.UserName,
                
            };

             

            if (NewUser.UserName == null || NewUser.Password == null)
            {
                Message = "Empty fields!";
                return Page();
            }

            if(NewUser.UserName != null || NewUser.Password != null) { 


            // måste ha minst en stor bokstav, min length-7 , !"#¤%&/ minst ett sådan tecken.
            var result = await _UserManager.CreateAsync(newUser, NewUser.Password);
                

                if (result.Succeeded)
            {
                    await _UserManager.AddToRoleAsync(newUser, "Attendee");
                    return RedirectToPage("/index");
            }
            else if (result.Succeeded == false)
            {
                    Message = "Password or Username dident work!";
            }

            }

            return Page();
        }
    }
}
