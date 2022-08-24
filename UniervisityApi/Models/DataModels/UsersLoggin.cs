using System.ComponentModel.DataAnnotations;

namespace UniervisityApi.Models.DataModels
{
    public class UsersLoggin: BaseEntity
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
