using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{
    class ProductContext : DbContext
    {

            public DbSet<Product> Products { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder builder)
            {
                builder.UseSqlServer(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=MVC;Integrated Security=True; MultipleActiveResultSets=True");
            }

    }
}
