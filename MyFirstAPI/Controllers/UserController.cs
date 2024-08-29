using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Communication.Requests;
using MyFirstAPI.Communication.Responses;

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
        public IActionResult GetByID([FromQuery] int Id, [FromQuery] string? nickname)
        {
            var response = new User
            {
                Id = 1,
                Age = 21,
                Name = "João Moraes"
            };
            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
        public IActionResult CreateUser([FromBody] RequestRegisterUserJson request)
        {
            var response = new ResponseRegisterUserJson
            {
                Id = 1,
                Name = request.Name,
            };
            return Created(string.Empty, response);
        }

        [HttpPut]
        //[Route("{id}")]
        //[FromRoute] int id "Se fizer sentido atualizar o perfil de outro usuário se não o logado"
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromBody] RequestUpdateUserProfileJson request)
        {
            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete()
        {
            return NoContent();
        }
    }
}
