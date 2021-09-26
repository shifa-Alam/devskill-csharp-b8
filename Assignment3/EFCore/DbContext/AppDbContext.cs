using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class AppDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public AppDbContext()
        {
            _connectionString = ConnectionStringReader.Connection;
            _assemblyName = typeof(Program).Assembly.FullName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Enrollment>()
                .HasKey(e => new { e.StudentId, e.CourseId });

            builder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.StudentId);

            builder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);
        }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
