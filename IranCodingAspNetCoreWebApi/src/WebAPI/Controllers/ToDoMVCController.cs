using Application.Models.ToDos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ToDoMVCController : Controller
    {
        [HttpPost]
        public IActionResult CreateToDo([FromBody]ToDoDto dto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok();
        }
    }
}
