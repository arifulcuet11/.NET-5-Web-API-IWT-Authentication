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
                context.SaveChanges();
            }
        }
    }
}
