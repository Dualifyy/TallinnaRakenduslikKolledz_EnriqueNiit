namespace TRK_TARpe24EN.Models;
using System.ComponentModel.DataAnnotations;

public enum DepartmentStatus
{
    Suletud,Avatud,Pausil,Deprecated,Ootel
}
public class Department
{
    [Key]
    public int DepartmentID { get; set; }
    public string Name { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartDate { get; set; }
    public int? InstructorID { get; set; }
    public Instructor? Administrator { get; set; }
    public ICollection<Course>? Courses { get; set; }
    public byte? RowVersion { get; set; }
    
    /* 3 isiklikut unikaalset andmevälja kursusele juurde*/
    
    public int? DepartmentWorkers {get; set;}
    public string? Location { get; set; }
    public string? CriminalCases  { get; set; }
}