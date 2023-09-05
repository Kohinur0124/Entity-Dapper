using EntityCRUD.Core.Enums;
using Microsoft.EntityFrameworkCore;
using School.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Data
{
    public class SchoolDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5432; User Id=postgres; Password=0124; Database=DataSchool");
            base.OnConfiguring(optionsBuilder);
        }
        #region DbSet
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        #endregion DbSet

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region SeedData Student
            modelBuilder.Entity<Student>().HasData(new List<Student>()
            {
                new Student
                { 
                    StudentId = 1,
                    FullName = "Xayriddinova Sevinch",
                    DOB = "01.02.2004",
                    Yonalish = Sub.Aniq,
                    Grade = 11,
                    PhoneNumber = "+998939613663",
                    Password = "Qwert123",
                    Mark = 100
                },
                new Student
                { 
                    StudentId = 2,
                    FullName = "Karimova Sadaf",
                    DOB = "01.01.2004",
                    Yonalish = Sub.Tabiiy,
                    Grade = 10,
                    PhoneNumber = "+998938853616",
                    Password = "123Qwert",
                    Mark = 80,

                }

            });
            #endregion SeedData Student

            #region SeedData Teacher

            modelBuilder.Entity<Teacher>().HasData(new List<Teacher>
            {
                new Teacher
                {
                    TeacherId = 1,
                    FullName = "Beknazarova Zulayho",
                    DOB = "23.01.19978",
                    Kirgan_yil = "2021",
                    PhoneNumber = "+998994027833",
                    Password = "Qwert123",
                    Mark = 100 ,
            }
            });
            #endregion SeedData Teacher

            #region SeedData Subject

            modelBuilder.Entity<Subject>().HasData(new List<Subject> {
                new Subject()
                {
                    SubjectId = 1,
                    SubjectName = "Matematika",
                    Yonalish = Sub.Aniq,
                },
                new Subject()
                {
                    SubjectId = 2,
                    SubjectName = "Fizika",
                    Yonalish = Sub.Aniq,
                },

                new Subject()
                {
                    SubjectId= 3,
                    SubjectName = "Biologiya",
                    Yonalish = Sub.Tabiiy,

                },
                new Subject()
                {
                    SubjectId = 4,
                    SubjectName = "Kimyo",
                    Yonalish = Sub.Tabiiy,

                },
                new Subject()
                {
                    SubjectId = 5,
                    SubjectName = "Ingliz tili",
                    Yonalish = Sub.Gumanitar,
                }
            });

            #endregion SeedData Subject

            base.OnModelCreating(modelBuilder);
        }


    }
}
