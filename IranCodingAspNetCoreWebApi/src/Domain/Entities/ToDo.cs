using Domain.Common;

namespace Domain.Entities
{
    public class ToDo : BaseEntity
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public virtual ICollection<ToDoItem> ToDoItems { get; set; }
    }
}
