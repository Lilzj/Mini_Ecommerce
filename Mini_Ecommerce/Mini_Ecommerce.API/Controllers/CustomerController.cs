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
                return BadRequest(BaseResponse.CreateResponse(message: "Customer Id not found", errs: ModelState, Customer: ""));
            }

            var customer = await _repo.GetCustomerByIdAsync(id);

            if(customer == null)
            {
                ModelState.AddModelError("Customer", "Customer does not exist");
                return NotFound(BaseResponse.CreateResponse(message: "Customer not found", errs: ModelState, Customer: ""));
            }

            var customerReturn = _map.Map<Customer, CustomerResponseDto>(customer);

            return Ok(BaseResponse.CreateResponse("Customer Details", null, customerReturn));
        }

        [HttpGet("customer-order/{id}", Name = "GetOrder")]
        public async Task<IActionResult> GetOrderById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                ModelState.AddModelError("Order", "Order id does not exist");
                return BadRequest(BaseResponse.CreateResponse(message: "Order Id not found", errs: ModelState, Customer: ""));
            }

            var order = await _repo.GetOrderByIdAsync(id);

            if (order == null)
            {
                ModelState.AddModelError("Order", "Order does not exist");
                return NotFound(BaseResponse.CreateResponse(message: "Order not found", errs: ModelState, Customer: ""));
            }

            return Ok(BaseResponse.CreateResponse("Order Details", null, order));
        }


        [HttpPost]
        public async Task<IActionResult> AddCustomer([FromBody] CustomerRequestDto  model)
        {
            if (!ModelState.IsValid)
                return BadRequest(BaseResponse.CreateResponse(message: "Model state error", errs: ModelState, Customer: ""));

            var customer = _map.Map<CustomerRequestDto, Customer>(model);

            var response = await _repo.AddCustomerAsync(customer);

            if (!response)
            {
                ModelState.AddModelError("Customer", "Could not add Customer");
                return BadRequest(BaseResponse.CreateResponse(message: "Order not added", errs: ModelState, Customer: ""));
            }

            var customerReturn = _map.Map<Customer, CustomerResponseDto>(customer);

            return CreatedAtRoute("GetCustomer", new {id = customerReturn.CustomerId},
                BaseResponse.CreateResponse(message: "Customer added sucessfully", errs: null, Customer: customerReturn));
        }

        [HttpPost("customer-Order")]
        public async Task<IActionResult> AddOrder([FromBody] OrderRequestDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(BaseResponse.CreateResponse(message: "Model state error", errs: ModelState, Customer: ""));

            var order = _map.Map<OrderRequestDto, Order>(model);

            var response = await _repo.AddOrderAsync(order);

            if (!response)
            {
                ModelState.AddModelError("Order", "Could not add Order");
                return BadRequest(BaseResponse.CreateResponse(message: "Order not added", errs: ModelState, Customer: ""));
            }

            return CreatedAtRoute("GetOrder", new { id = order.OrderId },
                BaseResponse.CreateResponse(message: "Order added sucessfully", errs: null, Customer: order));
        }

        [HttpGet("search/{name}")]
        public async Task<IActionResult> GetCustomer(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest(BaseResponse.CreateResponse(message: "No name was provided", errs: ModelState, Customer: ""));
            }

            var customer = await _repo.SearchCustomerByNameAsync(name);

            if (customer == null)
            {
                ModelState.AddModelError("Customer", "Customer does not exist");
                return NotFound(BaseResponse.CreateResponse(message: "Book name not found", errs: ModelState, Customer: ""));
            }

            var customerReturn = _map.Map<IEnumerable<Customer>, IEnumerable<CustomerResponseDto>>(customer);

            return Ok(BaseResponse.CreateResponse("Customer Details", null, customerReturn));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCustomer(int? id)
        {
            if (!id.HasValue || id == 0)
            {
                ModelState.AddModelError("Customer", "Customer id does not exist");
                return BadRequest(BaseResponse.CreateResponse(message: "Customer Id not found", errs: ModelState, Customer: ""));
            }

            var customer = await _repo.GetCustomerByIdAsync(id);

            if (customer == null)
            {
                ModelState.AddModelError("Customer", "Customer does not exist");
                return NotFound(BaseResponse.CreateResponse(message: "Customer not found", errs: ModelState, Customer: ""));
            }

            var response = await _repo.DeleteCustomerAsync(id);

            if (!response)
            {
                ModelState.AddModelError("Customer", "Could not delete Customer");
                return BadRequest(BaseResponse.CreateResponse(message: "Customer not deleted", errs: ModelState, Customer: ""));
            }

            return Ok(BaseResponse.CreateResponse(message: "Customer deleted successfully", errs: null, Customer: ""));

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int? id, [FromBody] CustomerUpdateRequestDto model)
        {
            if (!id.HasValue || id == 0)
            {
                ModelState.AddModelError("Customer", "Customer id does not exist");
                return BadRequest(BaseResponse.CreateResponse(message: "Customer Id not found", errs: ModelState, Customer: ""));
            }

            if (!ModelState.IsValid)
                return BadRequest(BaseResponse.CreateResponse(message: "Model state error", errs: ModelState, Customer: ""));


            var customer = await _repo.GetCustomerByIdAsync(id);

            if (customer == null)
            {
                ModelState.AddModelError("Customer", "Customer does not exist");
                return NotFound(BaseResponse.CreateResponse(message: "Customer not found", errs: ModelState, Customer: ""));
            }

            customer = _map.Map<Customer>(model);

            customer.CustomerId = (int)id;

            var response = await _repo.UpdateCustomerAsync(customer);

            if (!response)
            {
                ModelState.AddModelError("Not updated", "Update not successful");
                return BadRequest(BaseResponse.CreateResponse(message: "Customer could not be updated", errs: ModelState, Customer: ""));
            }

            return Ok(BaseResponse.CreateResponse(message: "Customer updated successfully", errs: null, Customer: ""));
        }

        [HttpPut("customer-order/{id}")]
        public async Task<IActionResult> UpdateOrder(string id, [FromBody] OrderUpdateRequestDto model)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                ModelState.AddModelError("Order", "Order id does not exist");
                return BadRequest(BaseResponse.CreateResponse(message: "Order Id not found", errs: ModelState, Customer: ""));
            }

            if (!ModelState.IsValid)
                return BadRequest(BaseResponse.CreateResponse(message: "Model state error", errs: ModelState, Customer: ""));


            var order = await _repo.GetOrderByIdAsync(id);

            if (order == null)
            {
                ModelState.AddModelError("Customer", "Customer does not exist");
                return NotFound(BaseResponse.CreateResponse(message: "Customer not found", errs: ModelState, Customer: ""));
            }

            order = _map.Map<Order>(model);

            order.OrderId = id;

            var response = await _repo.UpdateOrderAsync(order);

            if (!response)
            {
                ModelState.AddModelError("Not updated", "Update not successful");
                return BadRequest(BaseResponse.CreateResponse(message: "Order could not be updated", errs: ModelState, Customer: ""));
            }

            return Ok(BaseResponse.CreateResponse(message: "Order updated successfully", errs: null, Customer: ""));
        }

    }
}
