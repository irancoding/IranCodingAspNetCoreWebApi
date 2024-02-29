using Application.Models.ToDos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class ToDoAPIController : ControllerBase
    {
        [HttpPost("{headerRoute?}")]
        public IActionResult CreateToDo(ToDoDto dto, [FromHeader]string? headerTitle, 
                                        [FromRoute] string? headerRoute, [FromQuery]string? queryTitle)
        {
            return Ok("This is ok");
        }
	}
}
