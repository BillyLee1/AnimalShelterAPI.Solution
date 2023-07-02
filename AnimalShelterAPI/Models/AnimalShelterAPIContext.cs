using Microsoft.EntityFrameworkCore;

namespace AnimalShelterAPI.Models
{
  public class AnimalShelterAPIContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterAPIContext(DbContextOptions<AnimalShelterAPIContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Soju", Species = "Cat", Age = 7 },
          new Animal { AnimalId = 2, Name = "Anju", Species = "Cat", Age = 10 },
          new Animal { AnimalId = 3, Name = "Evie", Species = "Dog", Age = 2 },
          new Animal { AnimalId = 4, Name = "Fred", Species = "Dog", Age = 4 },
          new Animal { AnimalId = 5, Name = "Lulu", Species = "Dog", Age = 22 }
        );
    }
  }
}
