using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraduPoject.Models
{
    public class CartItem
    {
        [Key]
        public int ID { get; set; } // معرف العنصر
        [ForeignKey("Product")]
        public int ProductID { get; set; } // معرف المنتج
        public int Quantity { get; set; } // الكمية
        [ForeignKey("cart")]
        public int CartID { get; set; }

        public virtual Cart cart { get; set; }
        public virtual Product Product { get; set; }
    }
}
