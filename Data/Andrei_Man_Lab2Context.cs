using Microsoft.EntityFrameworkCore;

public class Andrei_Man_Lab2Context(DbContextOptions<Andrei_Man_Lab2Context> options) : DbContext(options)
{
    public DbSet<Andrei_Man_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Andrei_Man_Lab2.Models.Publisher> Publisher { get; set; }
    public DbSet<Andrei_Man_Lab2.Models.Authors> Authors { get; set; } = default!;

}

