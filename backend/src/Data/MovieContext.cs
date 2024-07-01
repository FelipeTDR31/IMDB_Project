using backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions options) : base(options) {}

    public DbSet<Movie> Movie { get; set; }
}