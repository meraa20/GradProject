using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraduPoject.Models
{
    public class Report
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int? UserID { get; set; }
        [ForeignKey("BusinessOwner")]
        //businessOwner ID
        public int? BOID { get; set; }
        [ForeignKey("Review")]
        public int ReviewID { get; set; }

        public virtual User? User { get; set; }
        public virtual BusinessOwner? BusinessOwner { get; set; }
        public virtual Review Review { get; set; }
    }
}
