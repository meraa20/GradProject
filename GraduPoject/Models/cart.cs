using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq; 

namespace GraduPoject.Models
{
    public class Cart
    {
        public int CartID { get; set; } // معرف العربة
        [ForeignKey("User")]
        public int UserID { get; set; } // معرف المستخدم المرتبط بالعربة
        public virtual User User { get; set; } // العلاقة مع المستخدم
        public virtual ICollection<CartItem>? Items { get; set; } // العناصر الموجودة في العربة

        public Cart()
        {
            Items = new List<CartItem>(); // تهيئة مجموعة العناصر
        }

        // إضافة عنصر إلى العربة
        public void AddItem(Product product, int quantity)
        {
            var existingItem = Items.FirstOrDefault(i => i.ProductID == product.ID);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity; // زيادة الكمية إذا كان العنصر موجودًا بالفعل
            }
            else
            {
                Items.Add(new CartItem { ProductID = product.ID, Quantity = quantity }); // إضافة عنصر جديد
            }
        }

        // حساب المجموع الكلي للعربة
        public decimal TotalAmount()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Quantity * item.Product.Price; // حساب المجموع بناءً على الكمية والسعر
            }
            return total;
        }

        // إزالة عنصر من العربة
        public void RemoveItem(int productId)
        {
            var itemToRemove = Items.FirstOrDefault(i => i.ProductID == productId);
            if (itemToRemove != null)
            {
                Items.Remove(itemToRemove); // إزالة العنصر
            }
        }

        // تفريغ العربة
        public void ClearCart()
        {
            Items.Clear(); // إزالة جميع العناصر من العربة
        }
    }
}
