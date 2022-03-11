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
    class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            var Customers = new List<Customer>
            {
                new Customer { CustomerId = 1, Name = "Joshua Gbogodor", Gender = Gender.Male, Age = 30 },
                  new Customer
                     {
                      CustomerId = 2,
                         Name = "Diana Minna",
                         Gender = Gender.Female,
                         Age = 30
                  },
                   new Customer
                      {
                       CustomerId = 3,
                          Name = "Obinna John",
                          Gender = Gender.Male,
                          Age = 43
                   },
                    new Customer
                       {
                        CustomerId = 4,
                           Name = "Chizaram Beauty",
                           Gender = Gender.Female,
                           Age = 30
                    },
                      new Customer
                          {
                          CustomerId = 5,
                              Name = "Ngozi Nneka",
                              Gender = Gender.Female,
                              Age = 45
                      },
                       new Customer
                         {
                           CustomerId = 6,
                             Name = "Matthew Drone",
                             Gender = Gender.Male,
                             Age = 27
                       },
                        new Customer
                        {
                            CustomerId = 7,
                            Name = "Hope Osarobo",
                            Gender = Gender.Male,
                            Age = 36
                        }
            };

            builder.HasData((IEnumerable<Customer>)Customers);
 
        }

                          
    }
}
