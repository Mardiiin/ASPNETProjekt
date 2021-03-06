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
    public class LoginModel : PageModel
    {

        private readonly SignInManager<User> _signInManager;
        
        public LoginModel(SignInManager<User> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
           
        }

        [BindProperty]
        public InputModel LoginUser {get; set;}
        
        public class InputModel
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
                if (LoginUser.UserName == null || LoginUser.Password == null)
                {
                  Message = "Empty fields!" ;
                  return Page();
                }


            if (LoginUser.UserName != null || LoginUser.Password != null)
            {
                var loginResult = await _signInManager.PasswordSignInAsync(LoginUser.UserName, LoginUser.Password, false, false);



                if (loginResult.Succeeded)
                {
                   
                    return RedirectToPage("/index");
                }
                else
                {
                    Message = "No match!";
                    return Page();
                }

            }


            return Page();
        }

    }
}
