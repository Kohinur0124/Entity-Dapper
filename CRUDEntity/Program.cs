using EntityCRUD.Core.Enums;
using EntityCRUD.Core.ViewModel;
using School.Core.Model;
using School.Core.Service;

namespace CRUDEntity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceModel.AddStudent(new Student()
            {
                StudentId = 3,
                FullName = "Amira Xalilova",
                DOB = "01.02.2002",
                Yonalish = Sub.Tabiiy,
                Grade = 11,
                PhoneNumber = "+998931235445",
                Password = "Qwert123",
                Mark = 90

            });
            ServiceModel.GetAllStudents().ForEach(s => Console.WriteLine(s.FullName));
            ServiceModel.UpdateStudent(3, new StudentViewModel()
            {
                FullName = "Amira Xalilova",
                DOB = "01.02.2002",
                Yonalish = Sub.Tabiiy,
                Grade = 11,
                PhoneNumber = "+998931235445",
                Password = "123Qwert",
                Mark = 90

            });
            ServiceModel.DeleteStudent(3);
        }
    }
}