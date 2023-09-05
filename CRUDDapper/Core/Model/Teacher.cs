using EntityCRUD.Core.Interface;

namespace School.Core.Model
{
    public class Teacher : Person, ITeacher
    {
      
        public int TeacherId { get; set; }

        public override string FullName { get; set; }
        
        public override string DOB { get; set; }
        
        public string Kirgan_yil { get; set; }
        
        public override string PhoneNumber { get; set; }
        
        public override string Password { get; set; }
        
        public override int Mark { get; set; }

    }
}
