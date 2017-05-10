using System.ComponentModel.DataAnnotations;

namespace testing.Models
{
    public class LoginModel
    {
        [Display(Name = "Логін")]
        [MinLength(10)]
        public string Login { get; set; }

        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}