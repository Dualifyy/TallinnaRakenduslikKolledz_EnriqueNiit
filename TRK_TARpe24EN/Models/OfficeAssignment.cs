using System.ComponentModel.DataAnnotations;

namespace TRK_TARpe24EN.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
        [StringLength(50)]
        [Display(Name = "Kabinet")]
        public string Location { get; set; }
    }
}
