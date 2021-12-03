using ASP_RazorContoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP_RazorContoso.Data
{
    public class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }
            var Masangya = new Student
            {
                FirstName = "Kaye",
                LastName = "Masangya",
                EnrollmentDate = DateTime.Parse("2016-09-01")
            };

            var Castro = new Student
            {
                FirstName = "Russel",
                LastName = "Castro",
                EnrollmentDate = DateTime.Parse("2018-09-01")
            };

            var Franco = new Student
            {
                FirstName = "Kres",
                LastName = "Franco",
                EnrollmentDate = DateTime.Parse("2019-09-01")
            };

            var Pineda = new Student
            {
                FirstName = "Roland",
                LastName = "Pineda",
                EnrollmentDate = DateTime.Parse("2018-09-01")
            };

            var Tordecilla = new Student
            {
                FirstName = "Iggy",
                LastName = "Tordecilla",
                EnrollmentDate = DateTime.Parse("2018-09-01")
            };

            var Rebong = new Student
            {
                FirstName = "Aaron",
                LastName = "Rebong",
                EnrollmentDate = DateTime.Parse("2017-09-01")
            };

            var Seno = new Student
            {
                FirstName = "Maria",
                LastName = "Seno",
                EnrollmentDate = DateTime.Parse("2019-09-01")
            };

            var Padigos = new Student
            {
                FirstName = "Alyssa",
                LastName = "Padigos",
                EnrollmentDate = DateTime.Parse("2011-09-01")
            };

            var Peacock = new Lecturer
            {
                FirstName = "Derek",
                LastName = "Peacock",
                HireDate = DateTime.Parse("1995-03-11")
            };

            var Campion = new Lecturer
            {
                FirstName = "Kompel",
                LastName = "Campion",
                HireDate = DateTime.Parse("2002-07-06")
            };

            var Luker = new Lecturer
            {
                FirstName = "Justin",
                LastName = "Luker",
                HireDate = DateTime.Parse("1998-07-01")
            };

            var Day = new Lecturer
            {
                FirstName = "Nicholas",
                LastName = "Day",
                HireDate = DateTime.Parse("2001-01-15")
            };

            var Jones = new Lecturer
            {
                FirstName = "Richard",
                LastName = "Jones",
                HireDate = DateTime.Parse("2004-02-12")
            };

            var officeAssignments = new OfficeAssignment[]
            {
                new OfficeAssignment {
                    Lecturer = Peacock,
                    Location = "G5.01" },
                new OfficeAssignment {
                    Lecturer = Campion,
                    Location = "G3.02" },
                new OfficeAssignment {
                    Lecturer = Luker,
                    Location = "G3.03" },
            };

            context.AddRange(officeAssignments);

            var WebApplication = new Department
            {
                Name = "Web Application",
                Budget = 350000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = Peacock
            };

            var Business = new Department
            {
                Name = "NacSports",
                Budget = 100000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = Campion
            };

            var Networking = new Department
            {
                Name = "Networking",
                Budget = 350000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = Luker
            };

            var Engineering = new Department
            {
                Name = "Engineering",
                Budget = 100000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = Day
            };

            var MobileSystems = new Course
            {
                CourseID = 3141,
                Title = "Mobile Systems",
                Credits = 3,
                Department = Business,
                Lecturers = new List<Lecturer> { Day, Jones }
            };

            var DatabaseDesign = new Course
            {
                CourseID = 2021,
                Title = "Database Design",
                Credits = 3,
                Department = Business,
                Lecturers = new List<Lecturer> { Campion }
            };

            var NetworkingSystem = new Course
            {
                CourseID = 2042,
                Title = "Networking System",
                Credits = 3,
                Department = Networking,
                Lecturers = new List<Lecturer> { Jones }
            };

            var SoftwareEngineering = new Course
            {
                CourseID = 1045,
                Title = "Software Engineering",
                Credits = 4,
                Department = Engineering,
                Lecturers = new List<Lecturer> { Day }
            };


            var enrollments = new Enrollment[]
            {
                new Enrollment {
                    Student = Masangya,
                    Course = SoftwareEngineering,
                    Grade = Grades.A
                },
                    new Enrollment {
                    Student = Castro,
                    Course = NetworkingSystem,
                    Grade = Grades.C
                    },
                    new Enrollment {
                    Student = Franco,
                    Course = DatabaseDesign,
                    Grade = Grades.B
                    },
                    new Enrollment {
                    Student = Pineda,
                    Course = SoftwareEngineering,
                    Grade = Grades.B
                    },
                    new Enrollment {
                        Student = Tordecilla,
                    Course = MobileSystems,
                    Grade = Grades.B
                    },
                    new Enrollment {
                    Student = Rebong,
                    Course = MobileSystems,
                    Grade = Grades.B
                    },
                    new Enrollment {
                    Student = Seno,
                    Course = SoftwareEngineering,
                    },
                    new Enrollment {
                    Student = Padigos,
                    Course = NetworkingSystem,
                    Grade = Grades.B
                    },
            };

            context.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
