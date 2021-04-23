 using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Inlämning.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Inlämning.Data
{
    public class InlämningContext : IdentityDbContext<User>
    {

        public InlämningContext(DbContextOptions<InlämningContext> options)
            : base(options)
        {
        }


        public DbSet<Event> Events { get; set; }




        public void Seeding()
        {
            this.Database.EnsureCreated();

            if (Events.Any()) 
              
            {
                return;
            }



            Events.AddRange(new List<Event>()
            {



            });
            SaveChanges();







        }
    }
}
