using EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.services
{
    public class CourseService
    {
        AppDbContext context;
        public CourseService()
        {
            context = new AppDbContext();
        }

        public string Save(Course course)
        {
            try
            {
                context.Courses.Add(course);
                context.SaveChanges();

                return "SuccessFully Save";
            }
            catch (Exception)
            {

                throw;
            }

        }
        public string Update(Course course)
        {
            try
            {
                var existingCourse = context.Courses.Find(course.Id);
                if (existingCourse != null)
                {
                    existingCourse.Title = course.Title;
                    existingCourse.Fees = course.Fees;
                    existingCourse.DurationInHours = course.DurationInHours;

                    context.SaveChanges();

                }
                return "SuccessFully Updated";
            }
            catch (Exception)
            {

                throw;
            }

        }

        public string Delete (int id)
        {
            try
            {
                var existingCourse = context.Courses.Find(id);
                if (existingCourse != null)
                {
                    context.Courses.Remove(existingCourse);

                    context.SaveChanges();

                }
                return "SuccessFully Deleted";
            }
            catch (Exception)
            {

                throw;
            }

        }
        public IEnumerable<Course> GetAll()
        {
            try
            {
                return context.Courses.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
