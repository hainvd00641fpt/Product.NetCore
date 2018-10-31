using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductNetCore.Models;

namespace ProductNetCore.Controllers
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions options) 
            : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
