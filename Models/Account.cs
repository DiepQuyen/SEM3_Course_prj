using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public Role Role { get; set; }  // Navigation Property
    }
}