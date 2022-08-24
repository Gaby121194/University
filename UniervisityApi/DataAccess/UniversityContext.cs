using Microsoft.EntityFrameworkCore;
using UniervisityApi.Models.DataModels;

namespace UniervisityApi.DataAccess
{
    public class UniversityContext: DbContext
    {
        public UniversityContext (DbContextOptions<UniversityContext> options) : base(options)
        { }

        public DbSet<User>? Users { get; set; }

        public DbSet<Course>? Courses { get; set; }

        public DbSet<Chapter>? Chapters { get; set; }

        public DbSet<Student>? Students { get; set; }

        public DbSet<Category>? Categories { get; set; }

        public DbSet<UniervisityApi.Models.DataModels.UsersLoggin>? UsersLoggin { get; set; }
    }
}
