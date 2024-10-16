using System.ComponentModel.DataAnnotations;

namespace GraduPoject.Models
{
    public class CartItem
    {
        [Key]
        public int ID { get; set; } // معرف العنصر
        public int ProductID { get; set; } // معرف المنتج
        public int Quantity { get; set; } // الكمية

       
        public virtual Product Product { get; set; }
    }
}
