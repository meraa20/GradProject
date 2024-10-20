using GraduPoject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // Import this to enable async operations
using System.Security.Claims; // For user identity
using System.Threading.Tasks;
[Authorize]
public class NotificationController : Controller
{
   

    private readonly DbContexxt _dbContext;

    public NotificationController(DbContexxt dbContext)
    {
        _dbContext = dbContext;
    }

    // Fetch notifications for the logged-in user
    public async Task<IActionResult> Notification()
    {
       

        // Fetch notifications for this user
        var notifications = await _dbContext.Notifications
            .ToListAsync(); // Use async version

        // Pass the notifications to the view
        return View(notifications);
    }

    // Action to delete a notification by ID (called via POST method)
    [HttpPost]
    public async Task<IActionResult> Delete(int id)
    {
        // Find the notification by ID asynchronously
        var notification = await _dbContext.Notifications.FirstOrDefaultAsync(n => n.ID == id);

        if (notification != null)
        {
            // Remove the notification from the database
            _dbContext.Notifications.Remove(notification);
            await _dbContext.SaveChangesAsync(); // Save changes asynchronously
        }

        // Redirect back to the notifications page after deletion
        return RedirectToAction("Notification");
    }
}
