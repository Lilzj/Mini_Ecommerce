using Mini_Ecommerce.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Entities.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; } 
        public IEnumerable<Address> Address { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public Customer()
        {
            Address = new List<Address>();
            Orders = new List<Order>();
        }

    }
}
