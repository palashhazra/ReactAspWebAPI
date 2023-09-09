using System.ComponentModel.DataAnnotations;

namespace ReactASPCRUD.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string stname { get; set; }
        public string course { get; set; }
    }
}
