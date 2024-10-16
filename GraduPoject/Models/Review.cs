using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraduPoject.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public string ReviewText { get; set; }
        public DateTime DateTime { get; set; }
        public int Rate { get; set; }

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
