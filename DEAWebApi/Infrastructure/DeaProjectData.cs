using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEAWebApi.Infrastructure
{
    public class DeaProjectData
    {
        public static class DbInitializer
        {
            public static void Initialize(ApplicationDbContext context)
            {
                context.Database.EnsureCreated();
                //if (context.Database.IsSqlServer())
                //{
                //    context.Database.Migrate();
                //}
                // Look for any students.
                //if (context.Users.Any())
                //{
                //    return;   // DB has been seeded
                //}

                //var Users = new User[]
                //{
                //    new User{Name="Carson",Email="admin@gmail.com",Password ="admin@123"},
                //};
                //foreach (User u in Users)
                //{
                //    context.Users.Add(u);
                //}
                //context.SaveChanges();
            }
        }
    }
}
