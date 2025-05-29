using System.ComponentModel.DataAnnotations;

namespace UserManagementAPI.Models.Authentication.SignUp
{
    public class Register
    {
        [Required(ErrorMessage = "User Name is Required")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string? Password { get; set; }
    }
}
