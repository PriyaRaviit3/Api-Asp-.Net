using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Data
{
    public class ItemsDbContext : DbContext
    {
        public ItemsDbContext(DbContextOptions<ItemsDbContext> options) : base(options)
        {

        }

        public DbSet<Items> items { get; set; }
       /* protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Convention.Remove<PluralizingTableNameConvention>();
        }*/
    
    }
}


