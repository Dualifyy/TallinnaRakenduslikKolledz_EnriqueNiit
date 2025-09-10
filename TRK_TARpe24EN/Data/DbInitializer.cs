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
                new Student
                {
                    FirstName = "George",
                    LastName = "Temu",
                    EnrollmentDate = DateTime.Now,
                }
            };
            
        }
    }
}
