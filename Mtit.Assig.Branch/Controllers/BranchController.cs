using Microsoft.AspNetCore.Mvc;
using Mtit.Assig.Branch.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mtit.Assig.Branch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService _branchService;

        public BranchController(IBranchService branchService)
        {

            _branchService = branchService ?? throw new ArgumentException(nameof(branchService));
        }
        // GET: api/<BranchController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_branchService.GetBranches());
        }

        // GET api/<BranchController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _branchService.GetBranch(id) != null ? Ok(_branchService.GetBranch(id)) : NoContent();
        }

        // POST api/<BranchController>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Branch branch)
        {
            return Ok(_branchService.AddBranch(branch));
        }

        // PUT api/<BranchController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Models.Branch branch)
        {
            return Ok(_branchService.UpdateBranch(branch));
        }

        // DELETE api/<BranchController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _branchService.DeleteBranch(id);

            return result.HasValue & result == true ? Ok($"Branch with ID:{id} got deleted successfully.") :
                BadRequest($"Unable to delete the Branch with Id:{id}");
        }
    }
}
