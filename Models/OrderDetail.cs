using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int CourseId { get; set; }
        public decimal Price { get; set; }
        public int? DiscountId { get; set; }
        public string Status { get; set; }  // Enum: 'pending', 'paid', 'error', 'canceled'
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public Order Order { get; set; }  // Navigation Property
        public Course Course { get; set; }  // Navigation Property
        public Discount Discount { get; set; }  // Navigation Property
    }
}