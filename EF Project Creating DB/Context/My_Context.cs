
using EF_Project_Creating_DB.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Project_Creating_DB
{
    public class My_Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-E9LOJRF\\SQLEXPRESS;DataBase=EF_Project;Trusted_Connection=true;Encrypt=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Instructor>().HasData(
           //    new Instructor { Id = 1, FirstName = "John", LastName = "Doe", Phone = "123-456-7890", DepartmentId = 1 },
           //    new Instructor { Id = 2, FirstName = "Jane", LastName = "Smith", Phone = "234-567-8901", DepartmentId = 2 },
           //    new Instructor { Id = 3, FirstName = "Alice", LastName = "Johnson", Phone = "345-678-9012", DepartmentId = 3 },
           //    new Instructor { Id = 4, FirstName = "Bob", LastName = "Brown", Phone = "456-789-0123", DepartmentId = 4 },
           //    new Instructor { Id = 5, FirstName = "Charlie", LastName = "Davis", Phone = "567-890-1234", DepartmentId = 5 },
           //    new Instructor { Id = 6, FirstName = "David", LastName = "Martinez", Phone = "678-901-2345", DepartmentId = 6 },
           //    new Instructor { Id = 7, FirstName = "Emily", LastName = "Garcia", Phone = "789-012-3456", DepartmentId = 7 },
           //    new Instructor { Id = 8, FirstName = "Frank", LastName = "Hernandez", Phone = "890-123-4567", DepartmentId = 8 },
           //    new Instructor { Id = 9, FirstName = "Grace", LastName = "Lopez", Phone = "901-234-5678", DepartmentId = 9 },
           //    new Instructor { Id = 10, FirstName = "Henry", LastName = "Miller", Phone = "012-345-6789", DepartmentId = 10 }
           //);
           // ///////////////////////////////////////////////////////////////////////////
           // modelBuilder.Entity<Department>().HasData(
           //    new Department { ID = 1, Name = "Computer Science", Location = "Building A", ManagerID = 1 },
           //    new Department { ID = 2, Name = "Electrical Engineering", Location = "Building B", ManagerID = 2 },
           //    new Department { ID = 3, Name = "Mechanical Engineering", Location = "Building C", ManagerID = 3 },
           //    new Department { ID = 4, Name = "Civil Engineering", Location = "Building D", ManagerID = 4 },
           //    new Department { ID = 5, Name = "Business Administration", Location = "Building E", ManagerID = 5 },
           //    new Department { ID = 6, Name = "Mathematics", Location = "Building F", ManagerID = 6 },
           //    new Department { ID = 7, Name = "Physics", Location = "Building G", ManagerID = 7 },
           //    new Department { ID = 8, Name = "Chemistry", Location = "Building H", ManagerID = 8 },
           //    new Department { ID = 9, Name = "Biology", Location = "Building I", ManagerID = 9 },
           //    new Department { ID = 10, Name = "Arts and Humanities", Location = "Building J", ManagerID = 10 }
           //);
           // ////////////////////////////////////////////////////////
           // modelBuilder.Entity<Course>().HasData(
           //      new Course { ID = 1, Name = "Introduction to Programming", Duration = 4, DepartmentID = 1, InstructorID = 1 },
           //      new Course { ID = 2, Name = "Advanced C# Programming", Duration = 5, DepartmentID = 1, InstructorID = 2 },
           //      new Course { ID = 3, Name = "Database Management Systems", Duration = 3, DepartmentID = 2, InstructorID = 3 },
           //      new Course { ID = 4, Name = "Web Development with ASP.NET", Duration = 4, DepartmentID = 3, InstructorID = 4 },
           //      new Course { ID = 5, Name = "Data Structures and Algorithms", Duration = 4, DepartmentID = 1, InstructorID = 5 },
           //      new Course { ID = 6, Name = "Software Engineering", Duration = 5, DepartmentID = 2, InstructorID = 6 },
           //      new Course { ID = 7, Name = "Computer Networks", Duration = 3, DepartmentID = 1, InstructorID = 7 },
           //      new Course { ID = 8, Name = "Artificial Intelligence", Duration = 5, DepartmentID = 3, InstructorID = 8 },
           //      new Course { ID = 9, Name = "Mobile App Development", Duration = 4, DepartmentID = 3, InstructorID = 9 },
           //      new Course { ID = 10, Name = "Cybersecurity Essentials", Duration = 4, DepartmentID = 2, InstructorID = 10 }
           //  );
           // ////////////////////////////////////////////////////////
           // modelBuilder.Entity<Student>().HasData(
           //     new Student { ID = 1, FirstName = "Ahmed", LastName = "Ali", Phone = "0100000001" },
           //     new Student { ID = 2, FirstName = "Sara", LastName = "Mohamed", Phone = "0100000002" },
           //     new Student { ID = 3, FirstName = "Ali", LastName = "Hassan", Phone = "0100000003" },
           //     new Student { ID = 4, FirstName = "Mona", LastName = "Kamal", Phone = "0100000004" },
           //     new Student { ID = 5, FirstName = "Omar", LastName = "Farouk", Phone = "0100000005" },
           //     new Student { ID = 6, FirstName = "Noha", LastName = "Said", Phone = "0100000006" },
           //     new Student { ID = 7, FirstName = "Khaled", LastName = "Mahmoud", Phone = "0100000007" },
           //     new Student { ID = 8, FirstName = "Yasmin", LastName = "Sami", Phone = "0100000008" },
           //     new Student { ID = 9, FirstName = "Tamer", LastName = "Rashad", Phone = "0100000009" },
           //     new Student { ID = 10, FirstName = "Heba", LastName = "Ashraf", Phone = "0100000010" }
           // );
           // //////////////////////////////////////////////////////
            
            
           // modelBuilder.Entity<CourseSession>().HasData(
           //     new CourseSession { Id = 1, CourseID = 1, InstructorID = 1, Date = DateTime.Now.AddDays(1), Title = "Introduction to Programming" },
           //     new CourseSession { Id = 2, CourseID = 2, InstructorID = 2, Date = DateTime.Now.AddDays(2), Title = "Advanced C# Programming" },
           //     new CourseSession { Id = 3, CourseID = 3, InstructorID = 3, Date = DateTime.Now.AddDays(3), Title = "Database Fundamentals" },
           //     new CourseSession { Id = 4, CourseID = 4, InstructorID = 4, Date = DateTime.Now.AddDays(4), Title = "Web Development Basics" },
           //     new CourseSession { Id = 5, CourseID = 5, InstructorID = 5, Date = DateTime.Now.AddDays(5), Title = "Data Structures and Algorithms" },
           //     new CourseSession { Id = 6, CourseID = 6, InstructorID = 6, Date = DateTime.Now.AddDays(6), Title = "Operating Systems Concepts" },
           //     new CourseSession { Id = 7, CourseID = 7, InstructorID = 7, Date = DateTime.Now.AddDays(7), Title = "Networking Essentials" },
           //     new CourseSession { Id = 8, CourseID = 8, InstructorID = 8, Date = DateTime.Now.AddDays(8), Title = "Software Engineering" },
           //     new CourseSession { Id = 9, CourseID = 9, InstructorID = 9, Date = DateTime.Now.AddDays(9), Title = "Cybersecurity Basics" },
           //     new CourseSession { Id = 10, CourseID = 10, InstructorID = 10, Date = DateTime.Now.AddDays(10), Title = "Cloud Computing" }
           // );

           //////////////////////////////////////////////////////////////////
           // modelBuilder.Entity<CourseSessionAttendance>().HasData(
           //     new CourseSessionAttendance { Id = 1, CourseSessionId = 1, StudentID = 1, Grade = 95, Notes = "Excellent participation" },
           //     new CourseSessionAttendance { Id = 2, CourseSessionId = 1, StudentID = 2, Grade = 85, Notes = "Good participation" },
           //     new CourseSessionAttendance { Id = 3, CourseSessionId = 2, StudentID = 3, Grade = 75, Notes = "Needs improvement" },
           //     new CourseSessionAttendance { Id = 4, CourseSessionId = 2, StudentID = 4, Grade = 90, Notes = "Active participation" },
           //     new CourseSessionAttendance { Id = 5, CourseSessionId = 3, StudentID = 5, Grade = 88, Notes = "Attended all sessions" },
           //     new CourseSessionAttendance { Id = 6, CourseSessionId = 3, StudentID = 6, Grade = 80, Notes = "Good performance" },
           //     new CourseSessionAttendance { Id = 7, CourseSessionId = 4, StudentID = 7, Grade = 92, Notes = "Excellent work" },
           //     new CourseSessionAttendance { Id = 8, CourseSessionId = 4, StudentID = 8, Grade = 78, Notes = "Missed some sessions" },
           //     new CourseSessionAttendance { Id = 9, CourseSessionId = 5, StudentID = 9, Grade = 89, Notes = "Good participation" },
           //     new CourseSessionAttendance { Id = 10, CourseSessionId = 5, StudentID = 10, Grade = 95, Notes = "Great attendance" }
           // );

           
            modelBuilder.Entity<CourseStudent>()
               .HasKey(cs => new { cs.CourseID, cs.StudentID });

            // Course <-> Instructor
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InstructorID)
                .OnDelete(DeleteBehavior.Restrict);

            // Course <-> Department
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Department)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.DepartmentID)
                .OnDelete(DeleteBehavior.Restrict);

            // Instructor <-> Department
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Department <-> Manager
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)  
                .WithMany()
                .HasForeignKey(d => d.ManagerID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>()
            .HasOne(d => d.Instructor)
            .WithMany()
            .HasForeignKey(d => d.ManagerID)
            .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

        //tables
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<CourseSession> CourseSessions { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }
        public DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }
    }
}
           
        