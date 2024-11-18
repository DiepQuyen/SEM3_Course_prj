using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class Token
    {
        [Key]
        public int TokenId { get; set; }
        public int UserId { get; set; }
        public string TokenValue { get; set; }
        public string TokenType { get; set; }  // 'OTP'
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public bool IsRevoked { get; set; }

        public Account User { get; set; }  // Navigation Property
    }
}