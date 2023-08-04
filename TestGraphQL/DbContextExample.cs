namespace TestGraphQL;

public class DbContextExample : DbContext
{
    public DbSet<Example> Examples { get; set; }

    public DbContextExample(DbContextOptions<DbContextExample> options) : base(options)
    {
    }
}
