using Microsoft.EntityFrameworkCore;
using TwoDo.StandardLib.Models;

namespace TwoDo.Data
{
  public class TwoDoContext : DbContext
  {
    public DbSet<ToDoItem> ToDos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=twodo.db");
    }
  }
}
