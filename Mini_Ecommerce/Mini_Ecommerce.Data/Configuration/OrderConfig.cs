using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mini_Ecommerce.Entities.Enum;
using Mini_Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Data.Configuration
{
    class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            var Orders = new List<Order>
            {
                 new Order
                            {
                     CustomerId= 1,
                                Amount = 300
                            },
                             new Order
                            {
                                 CustomerId=1,
                                Amount = 4000
                            },
                            new Order
                            {
                                CustomerId = 1,
                                Amount = 7500
                            },
                              new Order
                            {
                                  CustomerId = 2,
                                Amount = 300
                            },
                             new Order
                            {
                                 CustomerId = 2,
                                Amount = 4000
                            },
                            new Order
                            {
                                CustomerId = 2,
                                Amount = 7500
                            },
                             new Order
                            {
                                 CustomerId = 3,
                                Amount = 300
                            },
                             new Order
                            {
                                 CustomerId = 3,
                                Amount = 4000
                            },
                            new Order
                            {
                                CustomerId = 3,
                                Amount = 7500
                            },
                             new Order
                            {
                                  CustomerId = 4,
                                Amount = 300
                            },
                             new Order
                            {
                                 CustomerId = 4,
                                Amount = 4000
                            },
                            new Order
                            {
                                CustomerId = 4,
                                Amount = 6000
                            },
                              new Order
                            {
                                  CustomerId = 5,
                                Amount = 1000
                            },
                             new Order
                            {
                                  CustomerId = 5,
                                Amount = 450
                            },
                            new Order
                            {
                                 CustomerId = 5,
                                Amount = 800
                            },
                             new Order
                            {
                                 CustomerId = 6,
                                Amount = 300
                            },
                             new Order
                            {
                                 CustomerId = 6,
                                Amount = 4000
                            },
                            new Order
                            {
                                CustomerId = 6,
                                Amount = 7500
                            },
                            new Order
                            {
                                CustomerId = 7,
                                Amount = 8700
                            },
                             new Order
                            {
                                  CustomerId = 7,
                                Amount = 1450
                            },
                            new Order
                            {
                                 CustomerId = 7,
                                Amount = 1500
                            }
            };

            builder.HasData((IEnumerable<Order>)Orders);



        }


    }
}
