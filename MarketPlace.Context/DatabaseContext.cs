using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.Entity.Database_Entity;

namespace MarketPlace.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() : base("name=MarketPlaceDB")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
