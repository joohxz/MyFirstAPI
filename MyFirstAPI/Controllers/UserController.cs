using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //Primeiro endpoint
        //Query Param
        [HttpGet]
        //Path Param
        //[Route("{Id}/person/{nickname}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        public IActionResult GetResult([FromQuery] int Id, [FromQuery] string? nickname)
        {
            var response = new User
            {
                Id = 1,
                Age = 21,
                Name = "João Moraes"
            };
            return Ok(response);
        }
    }
}
