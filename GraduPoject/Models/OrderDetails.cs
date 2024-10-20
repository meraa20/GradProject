using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraduPoject.Models
{
    public class OrderDetails
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        [ForeignKey("Payment")]
        public int? PaymentID { get; set; }
        [ForeignKey("Delivery")]
        public int? DeliveryID { get; set; }

        public virtual Order Order { get; set; }

        public virtual ICollection<OrderProducts>? OrderProducts { get; set; }
        public virtual Payment? Payment { get; set; }
        public virtual Delivery? Delivery { get; set; }
    }
}
