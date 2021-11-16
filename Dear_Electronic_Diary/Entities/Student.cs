using System.ComponentModel.DataAnnotations;

namespace ElectronicDiary.Entities
{
    public partial class Student
    {
        [Key]
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string E_mail { get; set; }
        public string Phone { get; set; }

        //[ForeignKey("ID_Group")]
        public int GroupId { get; set; }
        public Group Group { get; set; }


        //[ForeignKey("ID_User")]
        public int UserId { get; set; }
        public User User { get; set; }

        public int Course { get; set; }

      
        //public List<Grade> Grades { get; set; }
    } 
}
