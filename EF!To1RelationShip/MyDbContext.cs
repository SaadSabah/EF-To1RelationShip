using Microsoft.EntityFrameworkCore;

namespace EF_To1RelationShip
{
    internal class MyDbContext : DbContext
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Cars&Engins;Integrated Security=True";
        public DbSet<Car> Cars { get; set; } //Creating Cars table
        public DbSet<Engine> Engines { get; set; } //Creating engines table
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We tell the app to use the connectionstring.
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder) //
        {
            ModelBuilder.Entity<Car>().HasData(new Car { Id = 1, Brand = "Toyota", Model = "Auris", Year = 2020 });
            ModelBuilder.Entity<Car>().HasData(new Car { Id = 2, Brand = "Volvo", Model = "V40", Year = 2022 });
            ModelBuilder.Entity<Car>().HasData(new Car { Id = 3, Brand = "SAAB", Model = "900T", Year = 2001 });

            ModelBuilder.Entity<Engine>().HasData(new Engine {  Id = 1, Volume = 2, NumberOfPistons = 4, CarId = 1 });
            ModelBuilder.Entity<Engine>().HasData(new Engine {  Id = 2, Volume = 4, NumberOfPistons = 6, CarId = 2 });
            ModelBuilder.Entity<Engine>().HasData(new Engine {  Id = 3, Volume = 6, NumberOfPistons = 8, CarId = 3 });
        }

    }
}
