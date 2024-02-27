using Domain.Common;

namespace Domain.Entities
{
    public class ToDoItem : BaseEntity
    {
        public required string Title { get; set; }
        public Guid ToDoId { get; set; }
        public bool IsComplete { get; set; }
        public virtual ToDo ToDo { get; set; }
    }
}
