using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inlämning.Pages
{
    public class RegisterModel : PageModel

    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public RegisterModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }


        public class LoginUserForm
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
        
            return Page();
        }
    }
}
