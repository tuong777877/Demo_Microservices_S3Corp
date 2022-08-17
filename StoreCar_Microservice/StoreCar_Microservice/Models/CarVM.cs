using StoreCar_Microservice.Entities;
using StoreCar_Microservice.Enums;

namespace StoreCar_Microservice.Model
{
    public class CarVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public StatusCar Status { get; set; }
        public string Descirption { get; set; }
        public DateTime? DateRelease { get; set; }
        public string NameCate { get; set; }
    }
}
