using Microsoft.EntityFrameworkCore;

public class ApplicationContext(DbContextOptions options) : DbContext(options) {
    public DbSet<Todo> Todos { get; set; }
}