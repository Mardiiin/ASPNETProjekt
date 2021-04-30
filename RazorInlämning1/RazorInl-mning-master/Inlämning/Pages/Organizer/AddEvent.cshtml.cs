using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Inlämning.Data;
using Inlämning.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inlämning.Pages.Organizer
{
    public class AddEventModel : PageModel
    {
        private readonly InlämningContext _context;
        private readonly UserManager<User> _userManager;


        public AddEventModel(InlämningContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]
        public Event Events { get; set; }

        [BindProperty]
        public string UserName { get; set;}

        public void OnGet()
        {

            Events = new Event();
    
        }


        public IActionResult OnPost()
        {

            UserName = User.FindFirstValue(ClaimTypes.Name);
      
            _context.Events.Add(Events);
            _context.SaveChanges();


            return Page();
        }
    }
}

