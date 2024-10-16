namespace GraduPoject.Models
{
    public class OrderProducts
    {
        public int OrderDetailsID { get; set; }
        public int ProductID { get; set; }

        public virtual Product Product { get; set; }
        public virtual OrderDetails OrderDetails { get; set; }
    }
}
