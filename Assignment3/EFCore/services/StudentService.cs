using EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.services
{
    public class StudentService
    {
        AppDbContext context;
        public StudentService()
        {
            context = new AppDbContext();
        }

        public string Save(Student student)
        {
            try
            {
                context.Students.Add(student);
                context.SaveChanges();

                return "SuccessFully Save";
            }
            catch (Exception)
            {

                throw;
            }

        }
        public string Update(Student student)
        {
            try
            {
                var existingStudent = context.Students.Find(student.Id);
                if (existingStudent != null)
                {
                    existingStudent.Name = student.Name;
                    existingStudent.DateOfBirth = student.DateOfBirth;
                    existingStudent.Address = student.Address;

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
                var existingStudent = context.Students.Find(id);
                if (existingStudent != null)
                {
                    context.Students.Remove(existingStudent);

                    context.SaveChanges();

                }
                return "SuccessFully Deleted";
            }
            catch (Exception)
            {

                throw;
            }

        }
        public IEnumerable<Student> GetAll()
        {
            try
            {
                return context.Students.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
