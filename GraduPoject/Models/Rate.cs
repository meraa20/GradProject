using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraduPoject.Models
{
    public class Rate
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public int RateNumber { get; set; }

        public virtual Product Product { get; set; }
    }
}
