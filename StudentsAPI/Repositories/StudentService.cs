using Microsoft.EntityFrameworkCore;
using StudentsAPI.Data;
using StudentsAPI.Entities;

namespace StudentsAPI.Repositories
{
    public class StudentService:IStudentService
    {
        private readonly StudentDbContext _context;
        public StudentService(StudentDbContext dbContext)
        { 
            _context=dbContext;
        }
        public List<Student> GetAllStudents()
        {
           return _context.StudentRegister.ToList();
        }
        public Student GetStudentById(int id)
        {
            return _context.StudentRegister.Find(id);
        }
        public void AddStudent(Student student)
        {
            _context.StudentRegister.Add(student);
            _context.SaveChanges(); 
        } 
        public void UpdateStudent(Student std,int id)
        {
           var student= _context.StudentRegister.Find(id);
            student.StudentName = std.StudentName;
            student.StudentAge = std.StudentAge;
            _context.SaveChanges();
        }
        public void DeleteStudent(int id)
        {
           var student= _context.StudentRegister.Find(id);
            _context.StudentRegister.Remove(student);
            _context.SaveChanges();
        }
    }
}
