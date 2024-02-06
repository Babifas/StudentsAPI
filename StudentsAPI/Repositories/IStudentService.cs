using StudentsAPI.Entities;

namespace StudentsAPI.Repositories
{
    public interface IStudentService
    {
      List<Student> GetAllStudents();
      Student GetStudentById(int id);
      void AddStudent(Student student);
      void UpdateStudent(Student student, int id);
      void DeleteStudent(int id);

    }
}
