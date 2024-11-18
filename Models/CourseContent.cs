using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class CourseContent
    {
        [Key]
        public int ContentId { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Course Course { get; set; }  // Navigation Property
    }
}