using System.ComponentModel.DataAnnotations;

namespace TRK_TARpe24EN.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        public DateTime  EnrollmentDate { get; set; }
        public int Age { get; set; }
        public float GradesPerAverage { get; set; }
        public string Gender { get; set; }



        /*Age, GPA, Gender */
    }
}
