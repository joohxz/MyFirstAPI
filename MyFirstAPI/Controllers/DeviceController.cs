using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Entitys;

namespace MyFirstAPI.Controllers
{
    public class DeviceController : MyFirstAPIBaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetModel()
        {
            var laptop = new Laptop();
            var model = laptop.GetModel();
            return Ok(model);
        }
    }
}
