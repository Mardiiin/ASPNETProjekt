using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inlämning.Pages.Shared
{
    [AllowAnonymous]
    public class NotAllowedModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
