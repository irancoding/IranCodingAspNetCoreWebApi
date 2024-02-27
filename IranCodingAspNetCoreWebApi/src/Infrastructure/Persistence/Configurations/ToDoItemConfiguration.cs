namespace Infrastructure.Persistence.Configurations
{
    internal class ToDoItemConfiguration : IEntityTypeConfiguration<ToDoItem>
    {
        public void Configure(EntityTypeBuilder<ToDoItem> builder)
        {
            builder.ToTable("ToDoItem");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(x => x.ToDo)
                .WithMany(x=>x.ToDoItems)
                .HasForeignKey(x => x.ToDoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
