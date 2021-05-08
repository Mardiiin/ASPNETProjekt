using Inlämning.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Inlämning.Pages
{
    [Authorize]
    public class MyEventsModel : PageModel
    {

        private readonly Inlämning.Data.InlämningContext _context;

        public MyEventsModel(Inlämning.Data.InlämningContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get; set; }
        public string Message { get; set; }



        public async Task OnGetAsync()
        {
            var myUser = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var attendee = await _context.Users.Where(x => x.Id == myUser).Include(b => b.JoinedEvents).SingleOrDefaultAsync();

            foreach(var x in attendee.JoinedEvents)
            {
                Event = await _context.Events.Where(y => y.Id == x.Id).Include(o => o.Organizer).ToListAsync();

            }

            Event = attendee.JoinedEvents;





        }
    }
}