using System.ComponentModel.DataAnnotations;

namespace testing.Models
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(25)]
        public string Login { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [MaxLength(25)]
        public string Surname { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }


    }
}