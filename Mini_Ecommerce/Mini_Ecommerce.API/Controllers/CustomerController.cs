using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Core.Interface;
using Mini_Ecommerce.Entities.DTO.Request;

namespace Mini_Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repo;

        public CustomerController(ICustomerRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public Task<IActionResult> AddCustomer(CustomerRequestDto  model)
        {
            ;
        }

    }
}
