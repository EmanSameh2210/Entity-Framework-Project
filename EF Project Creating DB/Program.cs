using EF_Project_Creating_DB.Models;
using Microsoft.EntityFrameworkCore;
namespace EF_Project_Creating_DB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            My_Context context = new My_Context();

            //context.Database.EnsureCreated();
            context.Database.Migrate();


            //if (!context.Students.Any())
            //{
            //    context.Students.AddRange(
            //    new Student { FirstName = "Ahmed", LastName = "Ali", Phone = "0100000001" },
            //    new Student { FirstName = "Sara", LastName = "Mohamed", Phone = "0100000002" },
            //    new Student { FirstName = "Ali", LastName = "Hassan", Phone = "0100000003" },
            //    new Student { FirstName = "Mona", LastName = "Kamal", Phone = "0100000004" },
            //    new Student { FirstName = "Omar", LastName = "Farouk", Phone = "0100000005" },
            //    new Student { FirstName = "Noha", LastName = "Said", Phone = "0100000006" },
            //    new Student { FirstName = "Khaled", LastName = "Mahmoud", Phone = "0100000007" },
            //    new Student { FirstName = "Yasmin", LastName = "Sami", Phone = "0100000008" },
            //    new Student { FirstName = "Tamer", LastName = "Rashad", Phone = "0100000009" },
            //    new Student { FirstName = "Heba", LastName = "Ashraf", Phone = "0100000010" }
            //);
            //    context.SaveChanges();
            //}

            ////////////////////////////////////////////////////////////
            //Console.WriteLine($"Departments count before seeding: {context.Departments.Count()}");
            //if (!context.Departments.Any())
            //{
            //    context.Departments.AddRange(
            //    new Department { Name = "Computer Science", Location = "Building A", ManagerID = null },
            //    new Department { Name = "Electrical ", Location = "Building B", ManagerID = null },
            //    new Department { Name = "Mechanical ", Location = "Building C", ManagerID = null },
            //    new Department { Name = "Civil Engineering", Location = "Building D", ManagerID = null },
            //    new Department { Name = "Administration", Location = "Building E", ManagerID = null },
            //    new Department { Name = "Mathematics", Location = "Building F", ManagerID = null },
            //    new Department { Name = "Physics", Location = "Building G", ManagerID = null },
            //    new Department { Name = "Chemistry", Location = "Building H", ManagerID = null },
            //    new Department { Name = "Biology", Location = "Building I", ManagerID = null },
            //    new Department { Name = "Arts and Humanities", Location = "Building J", ManagerID = null }
            //);
            //    context.SaveChanges();
            //}



            ////////////////////////////////////////////////////////////


            //if (!context.Courses.Any())
            //{
            //    context.Courses.AddRange(
            //    new Course { Name = "Introduction to Prog", Duration = 4, DepartmentID = 1, InstructorID = 1 },
            //    new Course { Name = "C# Programming", Duration = 5, DepartmentID = 1, InstructorID = 2 },
            //    new Course { Name = "Database Management", Duration = 3, DepartmentID = 2, InstructorID = 3 },
            //    new Course { Name = "ASP.NET", Duration = 4, DepartmentID = 3, InstructorID = 4 },
            //    new Course { Name = "Data Structures", Duration = 4, DepartmentID = 1, InstructorID = 5 },
            //    new Course { Name = "Software Engineering", Duration = 5, DepartmentID = 2, InstructorID = 6 },
            //    new Course { Name = "Computer Networks", Duration = 3, DepartmentID = 1, InstructorID = 7 },
            //    new Course { Name = "AI", Duration = 5, DepartmentID = 3, InstructorID = 8 },
            //    new Course { Name = "Mobile Development", Duration = 4, DepartmentID = 3, InstructorID = 9 },
            //    new Course { Name = "Cybersecurity", Duration = 4, DepartmentID = 2, InstructorID = 10 }
            //);
            //    context.SaveChanges();
            //}


            /////////////////////////////////////////////////////////////////////////////////////////////////






            //if (!context.Instructors.Any())
            //{
            //    context.Instructors.AddRange(
            //    new Instructor { FirstName = "John", LastName = "Doe", Phone = "123-456-7890", DepartmentId = 1 },
            //    new Instructor { FirstName = "Jane", LastName = "Smith", Phone = "234-567-8901", DepartmentId = 2 },
            //    new Instructor { FirstName = "Alice", LastName = "Johnson", Phone = "345-678-9012", DepartmentId = 3 },
            //    new Instructor { FirstName = "Bob", LastName = "Brown", Phone = "456-789-0123", DepartmentId = 4 },
            //    new Instructor { FirstName = "Charlie", LastName = "Davis", Phone = "567-890-1234", DepartmentId = 5 },
            //    new Instructor { FirstName = "David", LastName = "Martinez", Phone = "678-901-2345", DepartmentId = 6 },
            //    new Instructor { FirstName = "Emily", LastName = "Garcia", Phone = "789-012-3456", DepartmentId = 7 },
            //    new Instructor { FirstName = "Frank", LastName = "Hernandez", Phone = "890-123-4567", DepartmentId = 8 },
            //    new Instructor { FirstName = "Grace", LastName = "Lopez", Phone = "901-234-5678", DepartmentId = 9 },
            //    new Instructor { FirstName = "Henry", LastName = "Miller", Phone = "012-345-6789", DepartmentId = 10 }
            //);
            //    context.SaveChanges();
            //}

            ////////////////////////////////////////////////////////////////////////////////

            //if (!context.CourseSessions.Any())
            //{
            //    context.CourseSessions.AddRange(
            //    new CourseSession { CourseID = 11, InstructorID = 1, Date = DateTime.Now.AddDays(1), Title = "Introduction to Programming" },
            //    new CourseSession { CourseID = 2, InstructorID = 2, Date = DateTime.Now.AddDays(2), Title = "Advanced C# Programming" },
            //    new CourseSession { CourseID = 3, InstructorID = 3, Date = DateTime.Now.AddDays(3), Title = "Database Fundamentals" },
            //    new CourseSession { CourseID = 4, InstructorID = 4, Date = DateTime.Now.AddDays(4), Title = "Web Development Basics" },
            //    new CourseSession { CourseID = 5, InstructorID = 5, Date = DateTime.Now.AddDays(5), Title = "Data Structures and Algorithms" },
            //    new CourseSession { CourseID = 6, InstructorID = 6, Date = DateTime.Now.AddDays(6), Title = "Operating Systems Concepts" },
            //    new CourseSession { CourseID = 7, InstructorID = 7, Date = DateTime.Now.AddDays(7), Title = "Networking Essentials" },
            //    new CourseSession { CourseID = 8, InstructorID = 8, Date = DateTime.Now.AddDays(8), Title = "Software Engineering" },
            //    new CourseSession { CourseID = 9, InstructorID = 9, Date = DateTime.Now.AddDays(9), Title = "Cybersecurity Basics" },
            //    new CourseSession { CourseID = 10, InstructorID = 10, Date = DateTime.Now.AddDays(10), Title = "Cloud Computing" }
            //);
            //    context.SaveChanges();
            //}

            //    ////////////////////////////////////////////////////////////////////////////

            //if (!context.CourseSessionAttendances.Any())
            //{
            //    context.CourseSessionAttendances.AddRange(
            //    new CourseSessionAttendance { CourseSessionId = 11, StudentID = 1, Grade = 95, Notes = "Excellent participation" },
            //    new CourseSessionAttendance { CourseSessionId = 11, StudentID = 2, Grade = 85, Notes = "Good participation" },
            //    new CourseSessionAttendance { CourseSessionId = 12, StudentID = 3, Grade = 75, Notes = "Needs improvement" },
            //    new CourseSessionAttendance { CourseSessionId = 12, StudentID = 4, Grade = 90, Notes = "Active participation" },
            //    new CourseSessionAttendance { CourseSessionId = 3, StudentID = 5, Grade = 88, Notes = "Attended all sessions" },
            //    new CourseSessionAttendance { CourseSessionId = 3, StudentID = 6, Grade = 80, Notes = "Good performance" },
            //    new CourseSessionAttendance { CourseSessionId = 4, StudentID = 7, Grade = 92, Notes = "Excellent work" },
            //    new CourseSessionAttendance { CourseSessionId = 4, StudentID = 8, Grade = 78, Notes = "Missed some sessions" },
            //    new CourseSessionAttendance { CourseSessionId = 5, StudentID = 9, Grade = 87, Notes = "Regular attendee" },
            //    new CourseSessionAttendance { CourseSessionId = 5, StudentID = 10, Grade = 90, Notes = "Very engaged in the course" }
            //);
            //    context.SaveChanges();
            //}

            //    /////////////////////////////////////////////////////////////////////////////////

            if (!context.CourseStudents.Any())
            {
                context.CourseStudents.AddRange(
            new CourseStudent { CourseID = 6, StudentID = 1 },
            new CourseStudent { CourseID = 6, StudentID = 2 },
            new CourseStudent { CourseID = 2, StudentID = 3 },
            new CourseStudent { CourseID = 2, StudentID = 4 },
            new CourseStudent { CourseID = 3, StudentID = 5 },
            new CourseStudent { CourseID = 3, StudentID = 6 },
            new CourseStudent { CourseID = 4, StudentID = 7 },
            new CourseStudent { CourseID = 4, StudentID = 8 },
            new CourseStudent { CourseID = 5, StudentID = 9 },
            new CourseStudent { CourseID = 5, StudentID = 10 }
        );
                context.SaveChanges();
            }
            //}


        }

    }
}
