using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Entities.Models
{
    public class Customer
    {
        public string CustomerId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public byte Gender { get; set; }
        public int Age { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

    }
}
