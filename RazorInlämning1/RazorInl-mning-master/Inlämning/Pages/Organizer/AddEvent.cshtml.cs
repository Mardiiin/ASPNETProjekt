using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Inlämning.Data;
using Inlämning.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inlämning.Pages.Organizer
{
    [Authorize]
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


        public void OnGet()
        {

      
           


        }


        public IActionResult OnPost()
        {
            var UserName = User.FindFirstValue(ClaimTypes.Name);

            Events = new Event()
            {
                Title   = Events.Title,
                Address = Events.Address,
                SpotsAvailable = Events.SpotsAvailable,
                Date = Events.Date,
                Place = Events.Place,
                Description = Events.Description,
                Organizer = _userManager.Users.Where(o => o.UserName == UserName).FirstOrDefault(),
            };

            _context.Events.Add(Events);
            _context.SaveChanges();


            return Page();
        }
    }
}

