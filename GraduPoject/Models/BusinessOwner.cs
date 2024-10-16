using System.ComponentModel.DataAnnotations;

namespace GraduPoject.Models
{
    public class BusinessOwner
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public string NationalID { get; set; }
        public string Logo { get; set; }
        public string Bio { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
        public virtual ICollection<Notifications>? Notifications { get; set; }

    }
}
