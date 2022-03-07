using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Entities.Models
{
    public class Address
    {
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }
        public string PostCode { get; set; }
        public string Postcode { get; set; }
        public int HouseNumber { get; set; }
    }
}
