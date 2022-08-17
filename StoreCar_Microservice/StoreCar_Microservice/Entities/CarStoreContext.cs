using StoreCar_Microservice;
using Microsoft.EntityFrameworkCore;
using StoreCar_Microservice.Entities;
using static StoreCar_Microservice.Entities.CategoryCar;

namespace StoreCar_Microservice.Entities
{
    public class CarStoreContext :DbContext
    {
        public CarStoreContext(DbContextOptions<CarStoreContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CategoryCar> CateCars { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
