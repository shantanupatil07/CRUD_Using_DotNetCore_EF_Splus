﻿using Microsoft.EntityFrameworkCore;

namespace BambooBayEF.Models
{
    public class ProductDbContext:DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            
        }

        public DbSet<Product> Products { get; set; }

    }
}
