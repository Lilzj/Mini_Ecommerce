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
    class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
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

            builder.HasData((IEnumerable<Address>)Addresses);

        }


    }
}
