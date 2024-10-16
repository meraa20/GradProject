using Microsoft.EntityFrameworkCore;

namespace GraduPoject.Models
{
   
    public class DbContexxt:DbContext
    {
        public DbContexxt() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-VFQCRP5;Initial Catalog=GraduProject;Integrated Security=true;TrustServerCertificate=True;");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProducts>().HasKey(op => new { op.OrderDetailsID, op.ProductID});

            // One OrderDetails can have many Products
            modelBuilder.Entity<OrderProducts>()
                .HasOne(op => op.OrderDetails)
                .WithMany(od => od.OrderProducts)
                .HasForeignKey(op => op.OrderDetailsID);

            // One Product can appear in many OrderDetails
            modelBuilder.Entity<OrderProducts>()
                .HasOne(op => op.Product)
                .WithMany(p => p.OrderProducts)
                .HasForeignKey(op => op.ProductID);

            base.OnModelCreating(modelBuilder);
        }
        //Dbset
        public DbSet<Admin> Admins { get; set; }
        public DbSet<BusinessOwner> BusinessOwners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }


    }
}
