using System.ComponentModel.DataAnnotations;

namespace UniervisityApi.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public string CreateUser { get; set; } = string.Empty;

        public DateTime CreateDate { get; set; } = DateTime.Now;
        
        public string UpdatedUser { get; set; } = string.Empty;

        public DateTime? UpdatedDate { get; set; }

        public string DeletedUser { get; set; } = string.Empty;

        public DateTime? DeletedDate { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
