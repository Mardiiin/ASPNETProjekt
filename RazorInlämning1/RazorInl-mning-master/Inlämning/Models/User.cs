
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Inlämning.Models
{
    public class User : IdentityUser

    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [InverseProperty("Attendees")]
        public List<Event> JoinedEvents { get; set; }

        [InverseProperty("Organizer")]
        public List<Event> HostedEvents { get; set; }

        public List<IdentityRole> Roles { get; set; }



    }
}