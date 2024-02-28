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
        [HttpPost]
        public IActionResult CreateToDo(ToDoDto dto)
        {
            return Ok();
        }
    }
}
