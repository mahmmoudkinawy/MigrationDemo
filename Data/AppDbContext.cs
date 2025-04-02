using Microsoft.EntityFrameworkCore;

namespace MigrationDemo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Author> Authors { get; set; }
}

public sealed class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Bio { get; set; }
    public DateTimeOffset CreatedOn { get; set; }
}
