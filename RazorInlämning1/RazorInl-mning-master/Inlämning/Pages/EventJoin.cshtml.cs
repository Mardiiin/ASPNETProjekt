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
using System.Security.Claims;

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


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events.Include(x => x.Organizer).FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events.Include(e => e.Organizer).FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }

            var attendee = User.FindFirstValue(ClaimTypes.Name);

            if(attendee == null)
            {
                return NotFound();
            }


            var addEvent = await _userManager.Users.Where(x => x.UserName == attendee).Include(x => x.JoinedEvents).FirstOrDefaultAsync();
  


             if(!addEvent.JoinedEvents.Contains(Event))
             {
                 addEvent.JoinedEvents.Add(Event);
                 await _context.SaveChangesAsync();
                 return Page();
             }
             else
             {
                 return RedirectToPage("/MyEvents");
             }


        }
    }
}
