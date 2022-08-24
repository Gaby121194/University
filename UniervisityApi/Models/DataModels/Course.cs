using System.ComponentModel.DataAnnotations;

namespace UniervisityApi.Models.DataModels
{
    public enum Level
    {
        Basic,
        Intermediet,
        Advanced
    }
    public class Course : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required, MaxLength(250)]
        public string? ShortDescription { get; set; }
        [Required]
        public Level Level { get; set; } = Level.Basic;
        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();
        [Required]
        public Chapter Chapter { get; set; } = new Chapter();
    }
}
