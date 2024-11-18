using CourseManagementApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet cho các bảng
        public DbSet<Role> Roles { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CustomerInformation> CustomerInformation { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<CourseInformation> CourseInformation { get; set; }
        public DbSet<CourseContent> CourseContents { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình các ràng buộc
            modelBuilder.Entity<Account>()
                .HasOne(a => a.Role)
                .WithMany()
                .HasForeignKey(a => a.RoleId);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Category)
                .WithMany()
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.CustomerInformation)
                .WithMany()
                .HasForeignKey(o => o.CustomerInformationId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany()
                .HasForeignKey(od => od.OrderId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Course)
                .WithMany()
                .HasForeignKey(od => od.CourseId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Discount)
                .WithMany()
                .HasForeignKey(od => od.DiscountId);

            modelBuilder.Entity<Token>()
                .HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId);

            modelBuilder.Entity<CourseInformation>()
                .HasOne(ci => ci.Course)
                .WithMany()
                .HasForeignKey(ci => ci.CourseId);

            modelBuilder.Entity<CourseContent>()
                .HasOne(cc => cc.Course)
                .WithMany()
                .HasForeignKey(cc => cc.CourseId);

            modelBuilder.Entity<Class>()
                .HasOne(cl => cl.Course)
                .WithMany()
                .HasForeignKey(cl => cl.CourseId);

            modelBuilder.Entity<Class>()
                .HasOne(cl => cl.Instructor)
                .WithMany()
                .HasForeignKey(cl => cl.InstructorId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Class)
                .WithMany()
                .HasForeignKey(e => e.ClassId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.CustomerInformation)
                .WithMany()
                .HasForeignKey(e => e.CustomerInformationId);
        }
    }


}
