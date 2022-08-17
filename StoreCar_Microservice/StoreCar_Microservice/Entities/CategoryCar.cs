using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreCar_Microservice.Entities
{
    [Table("CategoryCar")]
    public class CategoryCar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
