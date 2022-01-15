#nullable disable
using Microsoft.EntityFrameworkCore;
using npk.back.Models;

namespace npk.back.EFCore;

public class PersonsDbContext : DbContext
{
  public DbSet<Person> Persons { get; set; }
  public PersonsDbContext(DbContextOptions<PersonsDbContext> options) : base(options)
  {
    Database.EnsureCreated();
  }
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersonConfiguration).Assembly);
  }
}
