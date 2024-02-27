using Microsoft.AspNetCore.Http;

namespace Application.Models.ToDos
{
    public class ToDoDto
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
