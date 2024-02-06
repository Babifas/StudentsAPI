using Microsoft.EntityFrameworkCore;
using StudentsAPI.Entities;

namespace StudentsAPI.Data
{
    public class StudentDbContext:DbContext
    {
       public StudentDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> StudentRegister { get; set; }
    }
}
