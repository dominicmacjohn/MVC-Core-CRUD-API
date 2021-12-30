using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MVC_Core_CRUD_API.Models;

namespace MVC_Core_CRUD_API.Data
{
    public static class DbInit
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Items.Any())
            {
                Console.WriteLine("--> Seeding Data...");
               
                context.Items.AddRange(
                    new Item { Name = "Item - AQ"  },
                    new Item { Name = "Item - HZ"},
                    new Item { Name = "Item - OP"},
                    new Item { Name = "Item - SF"},
                    new Item { Name = "Item - GT" }
                );

                context.SaveChanges();
            }
            else
                Console.WriteLine("--> There already is data");
        }
    }
}
