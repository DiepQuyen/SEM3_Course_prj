using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public Course Course { get; set; }  // Navigation Property
        public Instructor Instructor { get; set; }  // Navigation Property
    }
}