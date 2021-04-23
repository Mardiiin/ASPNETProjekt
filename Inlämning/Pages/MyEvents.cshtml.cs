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

namespace Inlämning.Pages
{
    [Authorize]
    public class MyEventsModel : PageModel
    {
        
        private readonly InlämningContext _context;

        public MyEventsModel(InlämningContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get; set; }
        public string Message { get; set; }

        public User _User { get; set; }



        public async Task<IActionResult> OnPostAsync(int? id)
        {
          


          //  var attendee = await _context.Users.Where(a => a.Id == id.ToString()).Include(e => e.).FirstOrDefaultAsync();

            var leaveEvent = await _context.Events.Where(e => e.EventID == id).FirstOrDefaultAsync();

            leaveEvent.SpotsAvailable++;

         //   attendee.Events.Remove(leaveEvent);
            await _context.SaveChangesAsync();
           
            return RedirectToPage($"/MyEvents", $"You have left the event: {leaveEvent.Title}");

         
        }
        public void OnGetAsync(string handler = "")
        {
          
          //  _User = _context.Users.Include(e => e.Events).FirstOrDefault();

            Message = handler;

           // Event = _User.Events;
            



        }
    }
}
