using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class CourseInformation
    {
        [Key]
        public int CourseInformationId { get; set; }
        public int CourseId { get; set; }
        public DateTime StartDate { get; set; }
        public string Duration { get; set; }
        public string StudyLevel { get; set; }
        public string TopicsIncluded { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Course Course { get; set; }  // Navigation Property
    }
}