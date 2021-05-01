using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public class OrganizeEventsModel : PageModel
    {
        private readonly InlämningContext _context;
        private readonly UserManager<User> _userManager;


        public OrganizeEventsModel(InlämningContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public string UserName { get; set; }
        public IList<Event> Event { get; set; }
        public async Task OnGetAsync()
        {
            Event = await _context.Events.Include(o => o.Organizer).ToListAsync();
            UserName = User.FindFirstValue(ClaimTypes.NameIdentifier);

 
        }
    }
}
