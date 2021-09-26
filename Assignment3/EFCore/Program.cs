using EFCore.Entities;
using EFCore.services;
using System;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Student
            StudentService studentService = new StudentService();

            Student saveStudent = new Student
            {
                Name = "Shifa",
                DateOfBirth = new DateTime(1994, 10, 8),
                Address = "Mirpur, Dhaka"

            };

            var addStudent = studentService.Save(saveStudent);
            Console.WriteLine(addStudent);

            Student updateStudent = new Student
            {
                Id = 1,
                Name = "jahid",
                DateOfBirth = new DateTime(1994, 10, 8),
                Address = "banani, Dhaka"

            };

            var modifiedStudent = studentService.Update(updateStudent);
            Console.WriteLine(modifiedStudent);


            var deleteStudent = studentService.Delete(1);
            Console.WriteLine(deleteStudent);


            var students = studentService.GetAll();
            if (students != null)
            {
                Console.WriteLine("Name         DOB              Address ");
                foreach (var student in students)
                {
                    Console.WriteLine($"{student.Name}, {student.DateOfBirth}, {student.Address}");

                }
            }

            #endregion

            #region Course

            CourseService courseService = new CourseService();
            Course saveCourse = new Course
            {
                Title = "Data stucture Algo",
                Fees = 120000,
                DurationInHours = 96

            };

            var addCourse = courseService.Save(saveCourse);
            Console.WriteLine(addCourse);

            Course updateCourse = new Course
            {
                Id = 1,
                Title = "C#",
                Fees = 10000,
                DurationInHours = 12

            };

            var modifiedCourse = courseService.Update(updateCourse);
            Console.WriteLine(modifiedCourse);


            var deleteCourse = courseService.Delete(1);
            Console.WriteLine(deleteCourse);


            var Courses = courseService.GetAll();
            if (Courses != null)
            {
                Console.WriteLine("Title     Fees     DurationInHours ");
                foreach (var Course in Courses)
                {
                    Console.WriteLine($"{Course.Title}, {Course.Fees}, {Course.DurationInHours}");

                }
            }

            #endregion


            #region Enrollment

            EnrollmentService EnrollmentService = new EnrollmentService();

            Enrollment saveEnrollment = new Enrollment
            {
                StudentId = 1,
                CourseId = 1,
                EnrollDate = DateTime.Now.AddDays(-15)

            };

            var addEnrollment = EnrollmentService.Save(saveEnrollment);
            Console.WriteLine(addEnrollment);

            Enrollment updateEnrollment = new Enrollment
            {
                StudentId = 1,
                CourseId = 1,
                EnrollDate = DateTime.Now

            };

            var modifiedEnrollment = EnrollmentService.Update(updateEnrollment);
            Console.WriteLine(modifiedEnrollment);


            var deleteEnrollment = EnrollmentService.Delete(1);
            Console.WriteLine(deleteEnrollment);


            var Enrollments = EnrollmentService.GetAll();
            if (Enrollments != null)
            {
                Console.WriteLine("StudentId     CourseId EnrollDate ");
                foreach (var Enrollment in Enrollments)
                {
                    Console.WriteLine($"{Enrollment.StudentId}, {Enrollment.CourseId}, {Enrollment.EnrollDate}");

                }
            }

            #endregion
        }
    }
}
