using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository;
using Models;

namespace aspnetcore_ef_async.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CustomerController> _logger;
        private readonly EfRepository<Customer> _repository;

        public CustomerController(ILogger<CustomerController> logger, EfRepository<Customer> repository)
        { 
            _repository = repository;
            _logger = logger;
        }

        [HttpPost]
        public  async Task<ActionResult<Customer>> CreateCustomer([FromBody] Customer cust)
        {
            Customer  createdCustomer = await _repository.Add(cust);
           

            
            return CreatedAtAction(nameof(Get), new { id = cust.FirstName }, cust);
           
        }

        [HttpGet]
        public IEnumerable<String> Get()
        {
            List<String> l = new List<string>{"hello", "world"};

            var rng = new Random();
                return l;
        }
    }
}
