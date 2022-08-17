using StoreCar_Microservice.Entities;
using StoreCar_Microservice.Enums;

namespace StoreCar_Microservice.Model
{
    public class CarModel
    {
        //public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Descirption { get; set; }
        public StatusCar Status { get; set; }
        //public string NameCate { get; set; }
        public int? IdCate { get; set; }
    }
}
