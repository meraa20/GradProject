using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraduPoject.Models
{
    public class Delivery
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Details")]
        public int OrderID { get; set; }
        public DateTime DateTime { get; set; }
        public int Price { get; set; }

        public virtual OrderDetails Details { get; set; }
    }
}
