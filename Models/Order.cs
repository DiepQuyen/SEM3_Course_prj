using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string CustomerInformationId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public CustomerInformation CustomerInformation { get; set; }  // Navigation Property
    }
}