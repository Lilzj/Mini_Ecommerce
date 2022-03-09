using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Core.Interface;
using Mini_Ecommerce.Entities.DTO.Request;
using Mini_Ecommerce.Entities.DTO.Response;
using Mini_Ecommerce.Entities.Models;

namespace Mini_Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repo;
        private readonly IMapper _map;

        public CustomerController(ICustomerRepository repo, IMapper map)
        {
            _repo = repo;
            _map = map;
        }


        [HttpGet("{id}", Name ="GetCustomer")]
        public async Task<IActionResult> GetCustomerById(int? id)
        {
            if (!id.HasValue || id == 0)
            {
                ModelState.AddModelError("Customer", "Customer id does not exist");
                return BadRequest(BaseResponse.CreateResponse(message: "Customer Id not found", errs: ModelState, data: ""));
            }

            var customer = await _repo.GetCustomerByIdAsync(id);

            if(customer == null)
            {
                ModelState.AddModelError("Customer", "Customer does not exist");
                return BadRequest(BaseResponse.CreateResponse(message: "Customer not found", errs: ModelState, data: ""));
            }

            var customerReturn = _map.Map<Customer, CustomerResponse>(customer);

            return Ok(BaseResponse.CreateResponse("Customer Details", null, customerReturn));
        }

        [HttpGet("{id}", Name = "GetOrder")]
        public async Task<IActionResult> GetOrderById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                ModelState.AddModelError("Order", "Order id does not exist");
                return BadRequest(BaseResponse.CreateResponse(message: "Order Id not found", errs: ModelState, data: ""));
            }

            var order = await _repo.GetOrderByIdAsync(id);

            if (order == null)
            {
                ModelState.AddModelError("Order", "Order does not exist");
                return BadRequest(BaseResponse.CreateResponse(message: "Order not found", errs: ModelState, data: ""));
            }

            return Ok(BaseResponse.CreateResponse("Order Details", null, order));
        }


        [HttpPost]
        public async Task<IActionResult> AddCustomer(CustomerRequestDto  model)
        {
            if (!ModelState.IsValid)
                return BadRequest(BaseResponse.CreateResponse(message: "Model state error", errs: ModelState, data: ""));

            var customer = _map.Map<CustomerRequestDto, Customer>(model);

            var response = await _repo.AddCustomerAsync(customer);

            if (!response)
            {
                ModelState.AddModelError("Customer", "Could not add Customer");
                return BadRequest(BaseResponse.CreateResponse(message: "Order not added", errs: ModelState, data: ""));
            }

            var customerReturn = _map.Map<Customer, CustomerResponse>(customer);

            return CreatedAtRoute("GetCustomer", new {id = customerReturn.CustomerId},
                BaseResponse.CreateResponse(message: "Customer added sucessfully", errs: null, data: customerReturn));
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(OrderRequestDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(BaseResponse.CreateResponse(message: "Model state error", errs: ModelState, data: ""));

            var order = _map.Map<OrderRequestDto, Order>(model);

            var response = await _repo.AddOrderAsync(order);

            if (!response)
            {
                ModelState.AddModelError("Order", "Could not add Order");
                return BadRequest(BaseResponse.CreateResponse(message: "Order not added", errs: ModelState, data: ""));
            }

            return CreatedAtRoute("GetOrder", new { id = order.OrderId },
                BaseResponse.CreateResponse(message: "Order added sucessfully", errs: null, data: order));
        }

        [HttpGet("{name}", Name = "search")]
        public async Task<IActionResult> GetCustomer(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest(BaseResponse.CreateResponse(message: "No name was provided", errs: ModelState, data: ""));
            }

            var customer = await _repo.SearchCustomerByNameAsync(name);

            if (customer == null)
            {
                ModelState.AddModelError("Customer", "Customer does not exist");
                return BadRequest(BaseResponse.CreateResponse(message: "Book name not found", errs: ModelState, data: ""));
            }

            var customerReturn = _map.Map<IEnumerable<Customer>, IEnumerable<CustomerResponse>>(customer);

            return Ok(BaseResponse.CreateResponse("Customer Details", null, customerReturn));
        }

    }
}
