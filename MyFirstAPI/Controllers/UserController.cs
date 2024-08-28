using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //Primeiro endpoint
        [HttpGet]
        public IActionResult GetResult()
        {
            var response = new Response
            {
                Age = 22,
                Name = "João Moraes"
            };
            return Ok(response);
        }
    }
}
