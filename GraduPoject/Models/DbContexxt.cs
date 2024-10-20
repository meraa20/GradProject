using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GraduPoject.ViewModel;

namespace GraduPoject.Models
{
    public class DbContexxt : IdentityDbContext<IdUser>
    {
        public DbContexxt() { }

        public DbContexxt(DbContextOptions<DbContexxt> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-VFQCRP5;Initial Catalog=GraduProject;Integrated Security=true;TrustServerCertificate=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define composite key for OrderProducts
            modelBuilder.Entity<OrderProducts>()
                .HasKey(op => new { op.OrderDetailsID, op.ProductID });

            // Define relationships
            modelBuilder.Entity<OrderProducts>()
                .HasOne(op => op.OrderDetails)
                .WithMany(od => od.OrderProducts)
                .HasForeignKey(op => op.OrderDetailsID);

            modelBuilder.Entity<OrderProducts>()
                .HasOne(op => op.Product)
                .WithMany(p => p.OrderProducts)
                .HasForeignKey(op => op.ProductID);

            // Ensure unique email addresses
            modelBuilder.Entity<IdUser>()
                .HasIndex(u => u.Email)
                .IsUnique();
            modelBuilder.Entity<User>()
        .HasOne(u => u.IdUser)
        .WithOne(i => i.User)
        .HasForeignKey<User>(u => u.useid);
   //         modelBuilder.Entity<BusinessOwner>().HasData(
   //    new BusinessOwner { ID = 1, Name = "Alice Smith", Email = "alice@example.com", Phone = "0123456789", Image = "alice.png", NationalID = "Pottery", Logo = "logo1.png", Bio = "Artisan of fine crafts.", useid = "1" },
   //    new BusinessOwner { ID = 2, Name = "Bob Johnson", Email = "bob@example.com", Phone = "0123456790", Image = "bob.png", NationalID = "Pottery", Logo = "logo2.png", Bio = "Specializing in handmade jewelry.", useid = "2" },
   //    new BusinessOwner { ID = 3, Name = "Charlie Brown", Email = "charlie@example.com", Phone = "0123456791", Image = "charlie.png", NationalID = "Pottery", Logo = "logo3.png", Bio = "Expert in vintage antiques.", useid = "3" },
   //    new BusinessOwner { ID = 4, Name = "Diana Prince", Email = "diana@example.com", Phone = "0123456792", Image = "diana.png", NationalID = "Pottery", Logo = "logo4.png", Bio = "Crafting unique pottery.", useid = "4" },
   //    new BusinessOwner { ID = 5, Name = "Edward Elric", Email = "edward@example.com", Phone = "0123456793", Image = "edward.png", NationalID = "Pottery", Logo = "logo5.png", Bio = "Alchemist and blacksmith.", useid = "5" },
   //    new BusinessOwner { ID = 6, Name = "Fiona Green", Email = "fiona@example.com", Phone = "0123456794", Image = "fiona.png", NationalID = "Pottery", Logo = "logo6.png", Bio = "Floral designer with a twist.", useid = "6" },
   //    new BusinessOwner { ID = 7, Name = "George Lucas", Email = "george@example.com", Phone = "0123456795", Image = "george.png", NationalID = "Pottery", Logo = "logo7.png", Bio = "Creating cinematic art.", useid = "7" },
   //    new BusinessOwner { ID = 8, Name = "Hannah Baker", Email = "hannah@example.com", Phone = "0123456796", Image = "hannah.png", NationalID = "Pottery", Logo = "logo8.png", Bio = "Sculptor of modern art.", useid = "8" }
   //);

            //         modelBuilder.Entity<Cart>().HasData(
            //             new Cart { CartID = 1, UserID = 1 },
            //             new Cart { CartID = 2, UserID = 2 },
            //             new Cart { CartID = 3, UserID = 3 },
            //             new Cart { CartID = 4, UserID = 4 },
            //             new Cart { CartID = 5, UserID = 5 },
            //             new Cart { CartID = 6, UserID = 6 },
            //             new Cart { CartID = 7, UserID = 7 },
            //             new Cart { CartID = 8, UserID = 8 }
            //         );

            //         modelBuilder.Entity<Category>().HasData(
            //             new Category { ID = 1, Name = "Art", Description = "All kinds of art products." },
            //             new Category { ID = 2, Name = "Crafts", Description = "Handmade crafts and decorations." },
            //             new Category { ID = 3, Name = "Antiques", Description = "Vintage and historical items." },
            //             new Category { ID = 4, Name = "Jewelry", Description = "Handcrafted jewelry and accessories." },
            //             new Category { ID = 5, Name = "Pottery", Description = "Unique ceramic and clay products." },
            //             new Category { ID = 6, Name = "Floral", Description = "Floral arrangements and designs." },
            //             new Category { ID = 7, Name = "Sculpture", Description = "Artistic sculptures and figures." },
            //             new Category { ID = 8, Name = "Photography", Description = "Artistic and creative photography." }
            //         );

            //         modelBuilder.Entity<Delivery>().HasData(
            //             new Delivery { ID = 1, OrderID = 1, DateTime = DateTime.Now, Price = 10 },
            //             new Delivery { ID = 2, OrderID = 2, DateTime = DateTime.Now.AddDays(1), Price = 15 },
            //             new Delivery { ID = 3, OrderID = 3, DateTime = DateTime.Now.AddDays(2), Price = 20 },
            //             new Delivery { ID = 4, OrderID = 4, DateTime = DateTime.Now.AddDays(3), Price = 12 },
            //             new Delivery { ID = 5, OrderID = 5, DateTime = DateTime.Now.AddDays(4), Price = 18 },
            //             new Delivery { ID = 6, OrderID = 6, DateTime = DateTime.Now.AddDays(5), Price = 22 },
            //             new Delivery { ID = 7, OrderID = 7, DateTime = DateTime.Now.AddDays(6), Price = 25 },
            //             new Delivery { ID = 8, OrderID = 8, DateTime = DateTime.Now.AddDays(7), Price = 30 }
            //         );

            //modelBuilder.Entity<Notifications>().HasData(
            //    new Notifications { ID = 1, Notification = "New product added!", UserID = 1, BOID = 1, DateTime = DateTime.Now },
            //    new Notifications { ID = 2, Notification = "Order shipped!", UserID = 2, BOID = 2, DateTime = DateTime.Now },
            //    new Notifications { ID = 3, Notification = "Review posted!", UserID = 3, BOID = 3, DateTime = DateTime.Now },
            //    new Notifications { ID = 4, Notification = "Price drop on your favorite product!", UserID = 4, BOID = 4, DateTime = DateTime.Now },
            //    new Notifications { ID = 5, Notification = "Special offer just for you!", UserID = 5, BOID = 5, DateTime = DateTime.Now },
            //    new Notifications { ID = 6, Notification = "New artist joined!", UserID = 6, BOID = 6, DateTime = DateTime.Now },
            //    new Notifications { ID = 7, Notification = "Your order is on the way!", UserID = 7, BOID = 7, DateTime = DateTime.Now },
            //    new Notifications { ID = 8, Notification = "New event coming up!", UserID = 8, BOID = 8, DateTime = DateTime.Now }
            //);

            //modelBuilder.Entity<Order>().HasData(
            //    new Order { ID = 1, UserID = 1, OrderDate = DateTime.Now, Status = "Shipped", Phone = "0123456789", TotalAmount = 100, Address = "123 Art St", OrderDetailsID = 1 },
            //    new Order { ID = 2, UserID = 2, OrderDate = DateTime.Now, Status = "Processing", Phone = "0123456790", TotalAmount = 200, Address = "456 Craft Rd", OrderDetailsID = 2 },
            //    new Order { ID = 3, UserID = 3, OrderDate = DateTime.Now, Status = "Delivered", Phone = "0123456791", TotalAmount = 150, Address = "789 Antique Ave", OrderDetailsID = 3 },
            //    new Order { ID = 4, UserID = 4, OrderDate = DateTime.Now, Status = "Cancelled", Phone = "0123456792", TotalAmount = 250, Address = "321 Jewelry Blvd", OrderDetailsID = 4 },
            //    new Order { ID = 5, UserID = 5, OrderDate = DateTime.Now, Status = "Pending", Phone = "0123456793", TotalAmount = 300, Address = "654 Pottery Ln", OrderDetailsID = 5 },
            //    new Order { ID = 6, UserID = 6, OrderDate = DateTime.Now, Status = "Shipped", Phone = "0123456794", TotalAmount = 180, Address = "987 Floral Ct", OrderDetailsID = 6 },
            //    new Order { ID = 7, UserID = 7, OrderDate = DateTime.Now, Status = "Delivered", Phone = "0123456795", TotalAmount = 220, Address = "135 Sculpture St", OrderDetailsID = 7 },
            //    new Order { ID = 8, UserID = 8, OrderDate = DateTime.Now, Status = "Processing", Phone = "0123456796", TotalAmount = 90, Address = "246 Photography Pl", OrderDetailsID = 8 }
            //);

            //modelBuilder.Entity<Product>().HasData(
            //    new Product { ID = 1, NameArtist = "Alice Smith", NameAntiqae = "Ceramic Vase", Description = "Beautiful ceramic vase.", Price = 50, CategoryID = 1, BOID = 1, Image = "~/images/1.jfif", RateID = 1 },
            //    new Product { ID = 2, NameArtist = "Bob Johnson", NameAntiqae = "Handmade Necklace", Description = "Stunning handmade necklace.", Price = 75, CategoryID = 2, BOID = 2, Image = "~/images/2.jfif", RateID = 2 },
            //    new Product { ID = 3, NameArtist = "Charlie Brown", NameAntiqae = "Vintage Clock", Description = "Antique clock from the 1800s.", Price = 150, CategoryID = 3, BOID = 3, Image = "~/images/3.jfif", RateID = 3 },
            //    new Product { ID = 4, NameArtist = "Diana Prince", NameAntiqae = "Clay Pot", Description = "Handmade clay pot.", Price = 25, CategoryID = 4, BOID = 4, Image = "~/images/8.jfif", RateID = 4 },
            //    new Product { ID = 5, NameArtist = "Edward Elric", NameAntiqae = "Iron Sculpture", Description = "Iron sculpture art.", Price = 100, CategoryID = 5, BOID = 5, Image = "~/images/4.jfif", RateID = 5 },
            //    new Product { ID = 6, NameArtist = "Fiona Green", NameAntiqae = "Floral Arrangement", Description = "Beautiful floral arrangement.", Price = 80, CategoryID = 6, BOID = 6, Image = "~/images/5.jfif", RateID = 6 },
            //    new Product { ID = 7, NameArtist = "George Lucas", NameAntiqae = "Photography Print", Description = "Stunning photography print.", Price = 60, CategoryID = 7, BOID = 7, Image = "~/images/6.jfif", RateID = 7 },
            //    new Product { ID = 8, NameArtist = "Hannah Baker", NameAntiqae = "Modern Sculpture", Description = "Contemporary sculpture art.", Price = 90, CategoryID = 8, BOID = 8, Image = "~/images/7.jfif", RateID = 8 }
            //);

            //modelBuilder.Entity<Rate>().HasData(
            //    new Rate { ID = 1, RateNumber = 5 },
            //    new Rate { ID = 2, RateNumber = 4 },
            //    new Rate { ID = 3, RateNumber = 3 },
            //    new Rate { ID = 4, RateNumber = 2 },
            //    new Rate { ID = 5, RateNumber = 1 },
            //    new Rate { ID = 6, RateNumber = 5 },
            //    new Rate { ID = 7, RateNumber = 4 },
            //    new Rate { ID = 8, RateNumber = 3 }
            //);

            //modelBuilder.Entity<Report>().HasData(
            //    new Report { ID = 1, UserID = 1, BOID = 1, ReviewID = 1 },
            //    new Report { ID = 2, UserID = 2, BOID = 2, ReviewID = 2 },
            //    new Report { ID = 3, UserID = 3, BOID = 3, ReviewID = 3 },
            //    new Report { ID = 4, UserID = 4, BOID = 4, ReviewID = 4 },
            //    new Report { ID = 5, UserID = 5, BOID = 5, ReviewID = 5 },
            //    new Report { ID = 6, UserID = 6, BOID = 6, ReviewID = 6 },
            //    new Report { ID = 7, UserID = 7, BOID = 7, ReviewID = 7 },
            //    new Report { ID = 8, UserID = 8, BOID = 8, ReviewID = 8 }
            //);

            //modelBuilder.Entity<Review>().HasData(
            //    new Review { ID = 1, UserID = 1, ProductID = 1, ReviewText = "Amazing product!", DateTime = DateTime.Now, Rate = 1 },
            //    new Review { ID = 2, UserID = 2, ProductID = 2, ReviewText = "Very satisfied!", DateTime = DateTime.Now, Rate = 2 },
            //    new Review { ID = 3, UserID = 3, ProductID = 3, ReviewText = "It's good, but could be better.", DateTime = DateTime.Now, Rate = 3 },
            //    new Review { ID = 4, UserID = 4, ProductID = 4, ReviewText = "Not what I expected.", DateTime = DateTime.Now, Rate = 4 },
            //    new Review { ID = 5, UserID = 5, ProductID = 5, ReviewText = "Love this item!", DateTime = DateTime.Now, Rate = 5 },
            //    new Review { ID = 6, UserID = 6, ProductID = 6, ReviewText = "Beautiful design.", DateTime = DateTime.Now, Rate = 6 },
            //    new Review { ID = 7, UserID = 7, ProductID = 7, ReviewText = "Highly recommend!", DateTime = DateTime.Now, Rate = 7 },
            //    new Review { ID = 8, UserID = 8, ProductID = 8, ReviewText = "Decent quality for the price.", DateTime = DateTime.Now, Rate = 8 }
            //);

            //modelBuilder.Entity<User>().HasData(
            //    new User { ID = 1, Name = "John Doe", Email = "john@example.com", Phone = "0123456789", password = "password123", Confirmpassword = "password123",useid = "1" },
            //    new User { ID = 2, Name = "Jane Smith", Email = "jane@example.com", Phone = "0123456790", password = "password123", Confirmpassword = "password123" , useid = "2" },
            //    new User { ID = 3, Name = "Michael Brown", Email = "michael@example.com", Phone = "0123456791", password = "password123", Confirmpassword = "password123", useid = "3" },
            //    new User { ID = 4, Name = "Emily Davis", Email = "emily@example.com", Phone = "0123456792", password = "password123", Confirmpassword = "password123", useid = "4" },
            //    new User { ID = 5, Name = "Chris Wilson", Email = "chris@example.com", Phone = "0123456793", password = "password123", Confirmpassword = "password123", useid = "5" },
            //    new User { ID = 6, Name = "Sarah Taylor", Email = "sarah@example.com", Phone = "0123456794", password = "password123", Confirmpassword = "password123", useid = "6" },
            //    new User { ID = 7, Name = "David Miller", Email = "david@example.com", Phone = "0123456795", password = "password123", Confirmpassword = "password123", useid = "7" },
            //    new User { ID = 8, Name = "Laura Martinez", Email = "laura@example.com", Phone = "0123456796", password = "password123", Confirmpassword = "password123", useid = "8" }
            //);






            base.OnModelCreating(modelBuilder); 
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BusinessOwner> BusinessOwner { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Rate> Rate { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Report> Report { get; set; }
    }
}
