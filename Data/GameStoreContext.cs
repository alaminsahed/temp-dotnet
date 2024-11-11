using Microsoft.EntityFrameworkCore;
using fistproject.Entities;
namespace fistproject.Data;


public class GameStoreContext(DbContextOptions<GameStoreContext> options) : DbContext(options)
{
    public DbSet<Game> Games { get; set; }
    public DbSet<Genre> Genres { get; set; }
}