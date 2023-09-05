using Dapper;
using EntityCRUD.Core.Enums;
using EntityCRUD.Core.ViewModel;
using Npgsql;
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
        public static string connectionString { get; set; } = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=0124; Database=DataSchool;";

        public static void UpdateStudent (int id,StudentViewModel student)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"UPDATE public.\"Students\"\r\n\tSET  \"FullName\"='{student.FullName}', \"DOB\"= '{student.DOB}', \"Yonalish\"= {Convert.ToInt32(student.Yonalish)}, \"Grade\"='{student.Grade}', \"PhoneNumber\"='{student.PhoneNumber}'," +
                    $" \"Password\"='{student.Password}', \"Mark\"='{student.Mark}'\r\n\tWHERE \"StudentId\"={id};";

                connection.Execute( sqlQuery);
                Console.WriteLine("Updated");
            }


        }

        public static void DeleteStudent(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"DELETE FROM public.\"Students\"WHERE \"StudentId\"={id};";

                connection.Execute(sqlQuery);
                Console.WriteLine("Deleted");
            }
        }

        public static void AddStudent(Student student)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"INSERT INTO public.\"Students\"(\r\n\t\"StudentId\", \"FullName\", \"DOB\", \"Yonalish\", \"Grade\", \"PhoneNumber\", \"Password\", \"Mark\")\r\n\t" +
                    $"VALUES ('{student.StudentId}','{student.FullName}','{student.DOB}',{Convert.ToInt32(student.Yonalish)},'{student.Grade}','{student.PhoneNumber}','{student.Password}','{student.Mark}');";

                connection.Execute(sqlQuery);
                Console.WriteLine("Added");
            }
        }

        public static List<Student> GetAllStudents()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = "SELECT * FROM public.\"Students\";";
                return    connection.Query<Student>(sqlQuery).ToList();
            }

        }

    }
}
