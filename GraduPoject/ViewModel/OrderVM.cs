namespace GraduPoject.ViewModel
{
    public class OrderVM
    {
        public List<CartItemsVM> CartItems { get; set; }
        public orderVM order { get; set; }

    }
    public class CartItemsVM
    {
        public int itemId { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
    public class orderVM
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime Time { get; set; }
        public string Phone { get; set; }
        public string PaymentMethod { get; set; }
    }
}
