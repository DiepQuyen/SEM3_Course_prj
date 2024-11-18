using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class Discount
    {
        [Key]
        public int DiscountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? Expires { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}