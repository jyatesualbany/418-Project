using System.ComponentModel.DataAnnotations;

namespace _418FinalProject.Models
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
        }

        [Display(Name = "User Name"),Required]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public string Type { get; set; }

    }
}
