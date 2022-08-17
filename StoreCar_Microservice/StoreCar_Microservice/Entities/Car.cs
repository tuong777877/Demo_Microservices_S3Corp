using StoreCar_Microservice.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreCar_Microservice.Entities
{
    [Table("Car")]
    public class Car
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public float Price { get; set; }
        [Required]
        [MaxLength(50)]
        public StatusCar Status { get; set; }
        public string Descirption { get; set; }
        public DateTime? DateRelease { get; set; }
        public int? IdCate { get; set; }
        [ForeignKey("IdCate")]
        public CategoryCar categorycar { get; set; }
        //public ICollection<OrderDetail> orderDetails { get; set; }
        //public Car()
        //{
        //    orderDetails = new List<OrderDetail>();
        //}
    }
}
