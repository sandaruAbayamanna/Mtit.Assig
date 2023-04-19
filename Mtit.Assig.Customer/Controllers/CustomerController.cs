using Microsoft.AspNetCore.Mvc;
using Mtit.Assig.Customer.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mtit.Assig.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {

            _customerService = customerService ?? throw new ArgumentException(nameof(customerService));
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_customerService.GetCustomers());
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _customerService.GetCustomer(id) != null ? Ok(_customerService.GetCustomer(id)) : NoContent();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Customer customer)
        {
            return Ok(_customerService.AddCustomer(customer));
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Models.Customer customer)
        {
            return Ok(_customerService.UpdateCustomer(customer));
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _customerService.DeleteCustomer(id);

            return result.HasValue & result == true ? Ok($"Customer with ID:{id} got deleted successfully.") :
                BadRequest($"Unable to delete the Customer with Id:{id}");

        }
    }
}
