using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraduPoject.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public string Phone { get; set; }
        public int TotalAmount { get; set; }
        public string Address { get; set; }
        [ForeignKey("Details")]
        public int OrderDetailsID { get; set; }

        public virtual OrderDetails Details { get; set; }
        public virtual User User { get; set; }
    }
}
