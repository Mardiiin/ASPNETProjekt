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
using System.Security.Claims;

namespace Inlämning.Pages
{
    [Authorize]
    public class OrganizeEventsModel : PageModel
    {
        private readonly InlämningContext _context;

        public OrganizeEventsModel(InlämningContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get; set; }

        public async Task OnGetAsync()
        {
            var UserName = User.FindFirstValue(ClaimTypes.Name);
            Event = await _context.Events.Include(o => o.Organizer).Where(o => o.Organizer.UserName == UserName).ToListAsync();


        }
    }
}
