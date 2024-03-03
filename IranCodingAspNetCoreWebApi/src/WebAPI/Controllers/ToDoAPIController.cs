using Application.Helpers;
using Application.Models.ToDos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class ToDoAPIController : ControllerBase
    {
        [HttpPost("{headerRoute?}")]

		[ProducesResponseType(StatusCodes.Status200OK)]
		//[ProducesResponseType(StatusCodes.Status200OK,Type =typeof(ToDoDto))]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]

		//[Consumes(MediaTypeNames.Application.Json)]
		//[Consumes(MediaTypeNames.Application.Xml)]
		// [Consumes(MediaTypeNames.Application.Xml,MediaTypeNames.Application.Json)]

		//[Produces(MediaTypeNames.Application.Json)]
		//[Produces(MediaTypeNames.Text.Plain)]
		[Produces(MediaTypeNames.Application.Xml)]
		public IActionResult CreateToDo(ToDoDto dto, [FromHeader]string? headerTitle, 
                                        [FromRoute] string? headerRoute, [FromQuery]string? queryTitle)
        {
            //return Ok("This is ok");
			return Ok(dto.ToXml());
		}
	}
}
