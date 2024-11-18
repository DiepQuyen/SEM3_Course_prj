using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class CustomerInformation
    {
        [Key]
        public string CustomerInformationId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public decimal? Mark { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}