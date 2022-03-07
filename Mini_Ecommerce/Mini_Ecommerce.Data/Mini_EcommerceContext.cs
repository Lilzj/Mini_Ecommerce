using Microsoft.EntityFrameworkCore;
using Mini_Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Data
{
    public class Mini_EcommerceContext : DbContext
    {
        public Mini_EcommerceContext(DbContextOptions<Mini_EcommerceContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
