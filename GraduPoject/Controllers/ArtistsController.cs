using GraduPoject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GraduProject.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly DbContexxt _context; // تصحيح الاسم

        public ArtistsController(DbContexxt context)
        {
            _context = context;
        }

        // عرض جميع الفنانين
        public IActionResult ArtistFollow()
        {
            var businessOwners = _context.BusinessOwner
                .Include(b => b.Products) // تضمين المنتجات المرتبطة بكل مالك عمل
                .ToList();

            if (businessOwners.Any()) // استخدام .Any() بدلاً من null للتحقق من وجود بيانات
            {
                return View(businessOwners);
            }
           
                return View(); // عرض صفحة أو رسالة إذا لم يكن هناك فنانون
            
            
        }
       

        // عرض تفاصيل فنان معين
        [Authorize]
        
        public IActionResult Artist(int id)
        {
            var artist = _context.BusinessOwner
                .Include(b => b.Products) // تضمين المنتجات المرتبطة بالفنان
                .ThenInclude(b => b.Rate) // تضمين التقييمات المرتبطة بكل منتج
                .FirstOrDefault(b => b.ID == id);

            if (artist != null)
            {
                return View(artist);
            }
            else
            {
                return View(); // عرض صفحة أو رسالة إذا لم يتم العثور على الفنان
            }
        }
    }
}
