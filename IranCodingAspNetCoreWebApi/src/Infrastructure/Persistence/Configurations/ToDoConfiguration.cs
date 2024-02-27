namespace Infrastructure.Persistence.Configurations
{
    internal class ToDoConfiguration : IEntityTypeConfiguration<ToDo>
    {
        public void Configure(EntityTypeBuilder<ToDo> builder)
        {
            builder.ToTable("ToDo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Description)
                .IsRequired(false)
                .HasMaxLength(300);

            builder.Property(x => x.ImagePath)
                .IsRequired(false)
                .HasMaxLength(200);
        }
    }
}
