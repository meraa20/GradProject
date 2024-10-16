using System.ComponentModel.DataAnnotations.Schema;

namespace GraduPoject.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        [ForeignKey("BusinessOwner")]
        //businessOwnerID
        public int BOID { get; set; }
        public string Image { get; set; }
        [ForeignKey("Rate")]
        public int RateID { get; set; }

        public virtual ICollection<OrderProducts> OrderProducts { get; set; }
        public virtual Rate? Rate { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
        public virtual Category Category { get; set; }
        public virtual BusinessOwner BusinessOwner { get; set; }
    }
}
