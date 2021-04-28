using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inlämning.Data;
using Inlämning.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Inlämning.Pages
{
    [Authorize]
    public class EventJoinModel : PageModel
    {
        private readonly InlämningContext _context;
        private readonly UserManager<User> _userManager;
        public EventJoinModel(InlämningContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public Event Event { get; set; }

        public User _User { get; set; }

        [BindProperty]
        public Event AddEvent { get; set; }
        public async Task<IActionResult> OnPostAsync(int? id)
        {


     
   

            return RedirectToPage("/MyEvents", $"You have joined this event.  see you there!");

        }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events.Include(o => o.Organizer).FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
