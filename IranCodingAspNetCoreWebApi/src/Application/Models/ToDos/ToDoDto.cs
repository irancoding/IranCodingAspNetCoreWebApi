using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Application.Models.ToDos
{
    public class ToDoDto
    {
		[Required(ErrorMessage = "عنوان را وارد نمایید")]
		public string Title { get; set; }
		public string? Description { get; set; }
		public IFormFile? ImageFile { get; set; }
	}
}
