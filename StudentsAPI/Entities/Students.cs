using System.ComponentModel.DataAnnotations;

namespace StudentsAPI.Entities
{
    public class Students
    {
        [Key]
        public int StudentId {  get; set; }
        public string? StudentName { get; set;}
        public int? StudentAge { get; set; }
        public string? StudentStandard {  get; set; }
        public string? StudentEmail { get; set; }

    }
}
