using System.ComponentModel.DataAnnotations;

namespace TemplateAssignmentBos.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public int Grade { get; set; }
    }
}