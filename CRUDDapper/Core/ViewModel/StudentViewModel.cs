using EntityCRUD.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCRUD.Core.ViewModel
{
    public class StudentViewModel
    {
        public  string FullName { get; set; }

        public string DOB { get; set; }

        public Sub Yonalish { get; set; }

        public int Grade { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public int Mark { get; set; }

       
    }
}
