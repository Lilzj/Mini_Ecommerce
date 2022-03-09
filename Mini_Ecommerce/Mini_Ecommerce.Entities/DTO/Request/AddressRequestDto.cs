using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Entities.DTO.Request
{
    public class AddressRequestDto
    {
        public string Street { get; set; }
        public string Postcode { get; set; }
        public int HouseNumber { get; set; }
    }
}
