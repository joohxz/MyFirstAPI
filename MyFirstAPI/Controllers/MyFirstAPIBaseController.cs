using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyFirstAPIBaseController : ControllerBase
    {

        public string Test { get; set; } = "Testando";
    }
}
