using TRK_TARpe24EN.Models;

namespace TRK_TARpe24EN.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();
            if (context.Students.Any())
            {
                return;
            }

            var student = new Student[]
            {
                new Student { FirstName = "George",  LastName = "Temu", EnrollmentDate = DateTime.Now, },
                new Student { FirstName = "Teorge",  LastName = "Jemu", EnrollmentDate = DateTime.Now, },
                new Student { FirstName = "Jeorge",  LastName = "Vemu", EnrollmentDate = DateTime.Now, },
                new Student { FirstName = "Veorge",  LastName = "Bemu", EnrollmentDate = DateTime.Now, },
                new Student { FirstName = "Beorge",  LastName = "Nemu", EnrollmentDate = DateTime.Now, },
                new Student { FirstName = "Neorge",  LastName = "Pemu", EnrollmentDate = DateTime.Now, },
                new Student { FirstName = "Peorge",  LastName = "Zemu", EnrollmentDate = DateTime.Now, },
                new Student { FirstName = "Zeorge",  LastName = "Demu", EnrollmentDate = DateTime.Now, }
            };
            context.Students.AddRange(student);
            context.SaveChanges();
            if (context.Courses.Any()) { return; }
            var course = new Course[]
            {
                new Course { CourseID = 1001, Title = "Programmeerimise Alused", Credits = 3 },
                new Course { CourseID = 2002, Title = "Programmeerimise 1", Credits = 6 },
                new Course { CourseID = 3003, Title = "Programmeerimise 2", Credits = 9 },
                new Course { CourseID = 2003, Title = "Tarkvara Arendusprotsess", Credits = 3 },
                new Course { CourseID = 1002, Title = "Multimeedia", Credits = 3 },
                new Course { CourseID = 1003, Title = "Hajusrakenduste Alused", Credits = 3 },
                new Course { CourseID = 9001, Title = "Krüpto vennas", Credits = 3 },
            };
            context.Courses.AddRange(course);
            context.SaveChanges();
            if (context.Enrollments.Any()) { return; }

            var enrollments = new Enrollment[]
            {
                new Enrollment { StudentID = 1, CourseID = 3001, CurrentGrade = Grade.X },
                new Enrollment { StudentID = 1, CourseID = 3003, CurrentGrade = Grade.B },
                new Enrollment { StudentID = 2, CourseID = 3001, CurrentGrade = Grade.C },
                new Enrollment { StudentID = 2, CourseID = 2003, CurrentGrade = Grade.C },
                new Enrollment { StudentID = 3, CourseID = 3001, CurrentGrade = Grade.X },
                new Enrollment { StudentID = 3, CourseID = 3002, CurrentGrade = Grade.A },
                new Enrollment { StudentID = 4, CourseID = 3001, CurrentGrade = Grade.C },
                new Enrollment { StudentID = 4, CourseID = 2003, CurrentGrade = Grade.C },
                new Enrollment { StudentID = 2, CourseID = 2003, CurrentGrade = Grade.C },
                new Enrollment { StudentID = 5, CourseID = 9001, CurrentGrade = Grade.D },
                new Enrollment { StudentID = 6, CourseID = 3001, CurrentGrade = Grade.X },
                new Enrollment { StudentID = 6, CourseID = 3003, CurrentGrade = Grade.B },
                new Enrollment { StudentID = 7, CourseID = 3001, CurrentGrade = Grade.C },
                new Enrollment { StudentID = 7, CourseID = 2003, CurrentGrade = Grade.C },
                new Enrollment { StudentID = 8, CourseID = 3001, CurrentGrade = Grade.X },
                new Enrollment { StudentID = 8, CourseID = 3002, CurrentGrade = Grade.A },
            };
            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
            if (context.Instructors.Any()) { return; }

            var instructors = new Instructor[]
            {
                new Instructor
                    { FirstName = "Abdul", LastName = "Labubu", HireDate = DateTime.Now, Salary = 934242342 },
                new Instructor
                    { FirstName = "Karin", LastName = "Eegreid", HireDate = DateTime.Now, Salary = 934242342 },
                new Instructor 
                    { FirstName = "Andrus", LastName = "Taat", HireDate = DateTime.Now, Salary = 934242342 },
                new Instructor
                    { FirstName = "Kristjan", LastName = "Taat", HireDate = DateTime.Now, Salary = 934242342 },
                new Instructor
                    { FirstName = "Mark", LastName = "Zimmerman", HireDate = DateTime.Now, Salary = 934242342 },
            };
            context.Instructors.AddRange(instructors);
            context.SaveChanges();
        }
    }
}
