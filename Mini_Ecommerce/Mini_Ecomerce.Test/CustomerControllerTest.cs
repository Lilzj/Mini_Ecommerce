using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.API.Controllers;
using Mini_Ecommerce.Core.Repository.Implementation;
using Mini_Ecommerce.Entities.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mini_Ecomerce.Test
{
    public class CustomerControllerTest
    {
        [Test]
        [Fact]
        public async Task GetCustomer_WithUnexistingCustomer_ReturnNotFound()
        {
            //Arrange
            var RepositorySub = new Mock<CustomerRepository>();
            RepositorySub.Setup(repo => repo.GetCustomerByIdAsync(It.IsAny<int?>()))
                .ReturnsAsync((Customer)null);

            var mapperSub = new Mock<IMapper>();

            var controller = new CustomerController(RepositorySub.Object, mapperSub.Object);

            //Act
            Random r = new Random();
            var result = await controller.GetCustomerById(r.Next(1, 50));

            //Assert
            Assert.IsAssignableFrom<NotFoundResult>(result);
        }
    }
}
