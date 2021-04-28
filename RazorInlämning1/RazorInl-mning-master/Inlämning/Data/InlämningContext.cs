using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Inlämning.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Inlämning.Data
{
    public class InlämningContext : IdentityDbContext<User>
    {

        public InlämningContext(DbContextOptions<InlämningContext> options)
            : base(options)
        {

        }


        public DbSet<Event> Events { get; set; }




        public async Task Seeding(
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
         

            await roleManager.CreateAsync(new IdentityRole("Attendee"));
            await roleManager.CreateAsync(new IdentityRole("Organizer"));
            await roleManager.CreateAsync(new IdentityRole("Admin"));

            User Attendee = new User()
            {
                UserName = "Attendee",
            };

            await userManager.CreateAsync(Attendee, "password");
            await userManager.AddToRoleAsync(Attendee, "Attendee");


            User[] organizer = new User[]
            {
                new User(){
                UserName = "SeinfeldCast",
                Email = "bigmoney@hotmail.com",
                
                
                },
                new User()
                {
                    UserName = "ThomasShelby",
                    Email = "2ndbigmoney@hotmail.com",

                }
            };

            foreach (var org in organizer)
            {
                await userManager.CreateAsync(org, "OGpassword");
                await userManager.AddToRoleAsync(org, "Organizer");
            }


            User Admin = new User()
            {
                UserName = "Admin",
                Email = "Admin@gmail.com"

            };


            await userManager.CreateAsync(Admin, "password");
            await userManager.AddToRoleAsync(Admin, "Admin");


  


            Events.AddRange(new List<Event>()
            {
              
                  new Event() { Title = "Beast",  Description= "GoodTime",  Organizer = Users.Where(o => o.UserName=="SeinfeldCast").FirstOrDefault(), Place= "North Yankton",  Address= "Pinkerton Road 12",   Date=DateTime.Parse ("2021-03-14 16:00"), SpotsAvailable= 120},
                  

            });
            SaveChanges();




            


        }
    }
}