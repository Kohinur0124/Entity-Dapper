using EntityCRUD.Core.Enums;

namespace School.Core.Model
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }

        public string ExamFileName { get; set; }

        public int SubjectId { get; set; }

        public int Soni { get; set; }

        public User Tip { get; set; }

        public Subject Subject { get; set; }
    }
}
