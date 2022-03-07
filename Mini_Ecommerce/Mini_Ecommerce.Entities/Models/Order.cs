using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Entities.Models
{
    public class Order
    {
        public string OrderId { get; set; } = Guid.NewGuid().ToString();
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

    }
}
