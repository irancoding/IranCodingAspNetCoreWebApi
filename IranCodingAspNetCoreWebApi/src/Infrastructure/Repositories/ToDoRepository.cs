using Application.Contracts;
using Application.Models.ToDos;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ToDoRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> CreateAsync(ToDoDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Title))
            {
                throw new Exception("todo title is required");
            }
            var todo = new ToDo
            {
                Title = dto.Title,
                Description = dto.Description
            };
            await _dbContext.ToDos.AddAsync(todo);
            await _dbContext.SaveChangesAsync();
            return todo.Id;
        }
    }
}
