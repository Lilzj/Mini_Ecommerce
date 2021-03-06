using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Entities.Models
{
    public class Address
    {
        public string AddressId { get; set; } = Guid.NewGuid().ToString();
        public int CustomerId { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public int HouseNumber { get; set; }
    }
}
