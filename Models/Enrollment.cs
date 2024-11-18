using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        public int ClassId { get; set; }
        public string CustomerInformationId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Class Class { get; set; }  // Navigation Property
        public CustomerInformation CustomerInformation { get; set; }  // Navigation Property
    }
}