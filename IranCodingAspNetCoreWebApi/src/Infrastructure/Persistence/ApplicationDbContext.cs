using Domain;
using System.Reflection;

namespace Infrastructure.Persistence
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			modelBuilder.HasDefaultSchema(DomainSchema.Schema);
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<ToDo> ToDos { get; set; }
		public DbSet<ToDoItem> ToDoItems { get; set; }
	}
}
