using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Core_CRUD_API.Models;

namespace MVC_Core_CRUD_API.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt)
            : base(opt)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}