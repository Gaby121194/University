using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniervisityApi.Models.DataModels
{
    public class Chapter: BaseEntity
    {
        [Required]
        public string Chapters { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public Course Course { get; set; } = new Course();
    }
}
