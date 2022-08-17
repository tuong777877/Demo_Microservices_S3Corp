using System.ComponentModel.DataAnnotations;

namespace StoreCar_Microservice.Model
{
    public class CategoryCarModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
