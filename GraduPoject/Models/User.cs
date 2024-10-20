using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraduPoject.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required,StringLength(20,MinimumLength =10)]  
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [ForeignKey("UserId")]
        public string useid { get; set; }
        public virtual IdUser IdUser { get; set; }

        public virtual ICollection<Payment>? Payments { get; set; }
        public virtual ICollection<Notifications>? Notifications { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
    }
}
