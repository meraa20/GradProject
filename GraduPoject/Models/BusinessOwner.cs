using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("IdUser")]
        public string useid { get; set; }
        public virtual IdUser IdUser { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
        public virtual ICollection<Notifications>? Notifications { get; set; }

    }
}
