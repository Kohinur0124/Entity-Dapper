using EntityCRUD.Core.ViewModel;
using School.Core.Data;
using School.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Service
{
    public static class ServiceModel
    {
        public static SchoolDb db = new SchoolDb();

        public  static void UpdateStudent (int id,StudentViewModel student)
        {
            var studens = db.Students.FirstOrDefault(s => s.StudentId == id);
            if(studens != null)
            {

                studens.FullName=student.FullName;
                studens.DOB = student.DOB;
                studens.Mark = student.Mark;
                studens.PhoneNumber = student.PhoneNumber;
                studens.Yonalish = student.Yonalish;
                studens.Password = student.Password;
                studens.Grade = student.Grade;


                db.Students.Update (studens);

                db.SaveChanges ();
                Console.WriteLine("Updated");
            }
            else
            {
                Console.WriteLine("Id not found");
            }

        }

        public static void DeleteStudent (int id)
        {
            var student = db.Students.FirstOrDefault(S => S.StudentId == id);

            if(student != null)
            {
                db.Remove (student);

                db.SaveChanges ();
                Console.WriteLine("Deleted");

            }
            else
            {
                Console.WriteLine("Id not found");
            }
        }

        public static void AddStudent (Student student)
        {
            
            db.Students.Add (student);

            db.SaveChanges ();
            Console.WriteLine("Created");
        }

        public static List<Student> GetAllStudents()
        {
            Console.WriteLine("Students:");

            return db.Students.ToList();


        }

    }
}
