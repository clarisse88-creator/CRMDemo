using Microsoft.AspNetCore.Mvc;

using Application.Services.Customers;
using Domain.Entities;
using Application.DTO;

namespace APICRMDemo.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet ("/api/customers")]
        public IEnumerable<Customer> GetCustomers()
        {
            return _customerService.GetAllCustomers(new CustomerFilterDTO(){});          
        }


        [HttpGet ("/api/customers/{id}")]
        public Customer GetCustomerById(int id)
        {
            return _customerService.GetCustomerById(id);
            
        }

        [HttpPost ("/api/customers")]
        public IActionResult CreateCustomer([FromBody] CustomerCreateDTO customerDTO)
        {
             _customerService.CreateCustomer(customerDTO);
             return Ok();
        }
    } 
