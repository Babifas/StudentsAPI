using System.ComponentModel.DataAnnotations;

namespace StudentsAPI.Entities
{
    public class Student
    {
        [Key]
        public int StudentId {  get; set; }
        public string? StudentName { get; set;}
        public int? StudentAge { get; set; }

    }
}
