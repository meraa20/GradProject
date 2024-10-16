using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraduPoject.Models
{
    public class Payment
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Details")]
        public int OrderDetailsID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public int Amount { get; set; }
        public DateTime DateTime { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }

        public virtual User User { get; set; }
        public virtual OrderDetails Details { get; set; }

    }
}
