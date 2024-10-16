using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraduPoject.Models
{
    public class Notifications
    {
        [Key]
        public int ID { get; set; }
        public string Notification { get; set; }
        [ForeignKey("User")]
        public int? UserID { get; set; }
        [ForeignKey("BusinessOwner")]
        //businessOwnerID
        public int? BOID { get; set; }
        public DateTime DateTime { get; set; }

        public virtual User? User { get; set; }
        public virtual BusinessOwner? BusinessOwner { get; set; }
    }
}
