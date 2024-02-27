using Application.Models.ToDos;

namespace Application.Contracts
{
    public interface IToDoRepository
    {
        Task<Guid> CreateAsync(ToDoDto dto);
    }
}
