using GraduPoject.Models;
using Microsoft.AspNetCore.Mvc;
using GraduPoject.ViewModel;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;

namespace GraduPoject.Controllers
{
    public class ShopController : Controller
    {
        private readonly DbContexxt _context;
        private readonly UserManager<IdUser> _userManager;

        public ShopController(DbContexxt context, UserManager<IdUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            List<ShopVM> shops = new List<ShopVM>();
            var products = _context.Products.ToList();
            foreach (var item in products)
            {
                ShopVM shop = new ShopVM
                {
                    id = item.ID,
                    ProductName = item.NameAntiqae,
                    ArtistName = _context.BusinessOwner.FirstOrDefault(x => x.ID == item.BOID)?.Name, // استخدام null conditional
                    Price = item.Price,
                    Description = item.Description,
                    Img = item.Image,
                    Rate = (int)(_context.Rate.FirstOrDefault(x => x.ID == item.RateID)?.RateNumber) // استخدام null conditional
                };
                shops.Add(shop);
            }
            return View("shop", shops);
        }

        public IActionResult Order()
        {
            // يجب استخدام UserID الحقيقي بدلاً من 3
            var userId = 3;
            var cart = _context.Carts.FirstOrDefault(x => x.UserID == userId);
            if (cart == null)
            {
                // يمكن معالجة حالة عدم وجود عربة هنا
                return View(new OrderVM { CartItems = new List<CartItemsVM>(), order = new orderVM() });
            }

            List<CartItem> items = _context.CartItems.Where(x => x.CartID == cart.CartID).ToList();
            List<CartItemsVM> cartItems = items.Select(item => new CartItemsVM
            {
                Quantity = item.Quantity,
                Name = _context.Products.FirstOrDefault(x => x.ID == item.ProductID)?.NameAntiqae,
                Img = _context.Products.FirstOrDefault(x => x.ID == item.ProductID)?.Image,
                Price = (int)(_context.Products.FirstOrDefault(x => x.ID == item.ProductID)?.Price),
                itemId = item.ID
            }).ToList();

            var subTotal = cartItems.Sum(i => i.Quantity * i.Price);
            ViewData["SubTotal"] = subTotal;

            var viewModel = new OrderVM
            {
                CartItems = cartItems,
                order = new orderVM() // تفاصيل الطلب فارغة ليقوم المستخدم بملئها
            };
            return View(viewModel);
        }

        // إضافة منتج إلى العربة
        public IActionResult AddToCart(int productID)
        {
            // يجب استخدام UserID الحقيقي بدلاً من 3
            int userId = 3;
            var cart = _context.Carts.FirstOrDefault(x => x.UserID == userId);
            if (cart == null)
            {
                // إنشاء عربة جديدة للمستخدم
                var newCart = new Cart { UserID = userId };
                _context.Carts.Add(newCart);
                _context.SaveChanges();

                // إضافة منتج إلى العربة الجديدة
                var item = new CartItem
                {
                    CartID = newCart.CartID,
                    ProductID = productID,
                    Quantity = 1
                };
                _context.CartItems.Add(item);
                _context.SaveChanges();
            }
            else
            {
                var item = _context.CartItems.FirstOrDefault(x => x.CartID == cart.CartID && x.ProductID == productID);
                if (item == null)
                {
                    // إذا لم يكن المنتج موجودًا، يتم إضافته
                    item = new CartItem
                    {
                        CartID = cart.CartID,
                        ProductID = productID,
                        Quantity = 1
                    };
                    _context.CartItems.Add(item);
                }
                else
                {
                    // إذا كان المنتج موجودًا، زيادة الكمية
                    item.Quantity++;
                    _context.CartItems.Update(item);
                }
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int itemID)
        {
            var item = _context.CartItems.FirstOrDefault(x => x.ID == itemID);
            if (item != null)
            {
                _context.CartItems.Remove(item);
                _context.SaveChanges();
            }
            return RedirectToAction("Order");
        }

        public IActionResult AddOrder(orderVM order)
        {
            int userID = 3; // يجب استخدام UserID الحقيقي بدلاً من 3
            var cartID = _context.Carts.FirstOrDefault(x => x.UserID == userID)?.CartID;
            if (cartID == null)
            {
                return RedirectToAction("Index", "Home"); // إذا لم توجد عربة، ارجع إلى الصفحة الرئيسية
            }

            var myItems = _context.CartItems.Where(x => x.CartID == cartID).ToList();
            var totAmount = myItems.Sum(item => item.Quantity * _context.Products.FirstOrDefault(x => x.ID == item.ProductID)?.Price ?? 0);
            var quantity = myItems.Sum(item => item.Quantity);

            var newOrder = new Order
            {
                UserID = userID,
                PaymentMethod = order.PaymentMethod,
                OrderDate = order.Time,
                Phone = order.Phone,
                Address = order.Address + " " + order.City,
                TotalAmount = totAmount
            };

            _context.Order.Add(newOrder);
            _context.SaveChanges();

            var orderDetails = new OrderDetails
            {
                OrderID = newOrder.ID,
                Quantity = quantity,
                Price = totAmount
            };
            _context.OrderDetails.Add(orderDetails);
            _context.SaveChanges();

            // بعد إتمام الطلب، قم بإزالة جميع العناصر من العربة
            _context.CartItems.RemoveRange(myItems);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
