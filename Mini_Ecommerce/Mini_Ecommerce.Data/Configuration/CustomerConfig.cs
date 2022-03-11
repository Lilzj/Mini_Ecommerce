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
            var Addresses = new List<Address>
            {
                 new Address
                            {
                     CustomerId = 1,
                                Street = "Adeoye street, Ikeja",
                                Postcode = "EA3454",
                                HouseNumber = 12
                            },
                             new Address
                            {
                                 CustomerId = 1,
                                Street = "Femi street, Ajah",
                                Postcode = "76523",
                                HouseNumber = 27
                            },
                               new Address
                            {
                                   CustomerId = 2,
                                Street = "Abidjo way, Ajah",
                                Postcode = "33455",
                                HouseNumber = 12
                            },
                             new Address
                            {
                                 CustomerId = 2,
                                Street = "Bodija-Badoo, Ajah",
                                Postcode = "37632",
                                HouseNumber = 6
                            },
                                                         new Address
                            {
                                CustomerId = 3,
                                Street = "Wfurun street, Ijaiye",
                                Postcode = "EA3454",
                                HouseNumber = 2
                            },
                             new Address
                            {
                                 CustomerId = 3,
                                Street = "Shoprite way, Sangotedo",
                                Postcode = "76523",
                                HouseNumber = 13
                            },
                              new Address
                            {
                                  CustomerId = 4,
                                Street = "Nzumba way, UK",
                                Postcode = "EA3454",
                                HouseNumber = 12
                            },
                             new Address
                            {
                                 CustomerId = 4,
                                Street = "Bush close, UK",
                                Postcode = "RT45322",
                                HouseNumber = 23
                            },
                              new Address
                            {
                                  CustomerId = 5,
                                Street = "Eleganza, Ikeja",
                                Postcode = "EA3454",
                                HouseNumber = 12
                            },
                             new Address
                            {
                                 CustomerId = 5,
                                Street = "Admiraty way, Island",
                                Postcode = "76523",
                                HouseNumber = 27
                            },
                              new Address
                            {
                                  CustomerId = 6,
                                Street = "Akenbor sokponba Rd",
                                Postcode = "44556",
                                HouseNumber = 10
                            },
                             new Address
                            {
                                 CustomerId = 6,
                                Street = "Alonshe close, Benin",
                                Postcode = "76523",
                                HouseNumber = 16
                            },
                              new Address
                            {
                                  CustomerId = 7,
                                Street = "University Road, Yaba",
                                Postcode = "FT2563",
                                HouseNumber = 2
                            },
                             new Address
                            {
                                 CustomerId = 7,
                                Street = "Asanjo way, Ajah",
                                Postcode = "88733",
                                HouseNumber = 17
                            }
            };
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

            builder.HasData((IEnumerable<Customer>)Customers);
            builder.HasData((IEnumerable<Address>)Addresses);
            builder.HasData((IEnumerable<Order>)Orders);



        }

                          
    }
}
