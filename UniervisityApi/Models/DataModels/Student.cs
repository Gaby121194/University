using System.ComponentModel.DataAnnotations;

namespace UniervisityApi.Models.DataModels
{
    public class Student: BaseEntity
    {
        [Required, StringLength(50)]
        public string? Name { get; set; }
        [Required, StringLength(50)]
        public string? LastName { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
