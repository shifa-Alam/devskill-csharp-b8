using EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.services
{
    public class EnrollmentService
    {
        AppDbContext context;
        public EnrollmentService()
        {
            context = new AppDbContext();
        }

        public string Save(Enrollment enrollment)
        {
            try
            {
                context.Enrollments.Add(enrollment);
                context.SaveChanges();

                return "SuccessFully Save";
            }
            catch (Exception)
            {

                throw;
            }

        }
        public string Update(Enrollment enrollment)
        {
            try
            {
                var existingEnrollment = context.Enrollments.FirstOrDefault(e=>e.CourseId==enrollment.CourseId && e.StudentId==enrollment.StudentId);
                if (existingEnrollment != null)
                {
                    existingEnrollment.EnrollDate = enrollment.EnrollDate;
                  
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
                var existingEnrollment = context.Enrollments.Find(id);
                if (existingEnrollment != null)
                {
                    context.Enrollments.Remove(existingEnrollment);

                    context.SaveChanges();

                }
                return "SuccessFully Deleted";
            }
            catch (Exception)
            {

                throw;
            }

        }
        public IEnumerable<Enrollment> GetAll()
        {
            try
            {
                return context.Enrollments.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
