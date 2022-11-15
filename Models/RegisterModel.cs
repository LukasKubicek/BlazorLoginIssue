using System.ComponentModel.DataAnnotations;

namespace EmptyBlazorApp1.Models
{
    public class RegisterAccountForm
    {
        [Required(ErrorMessage = "Email requiered")]
        [EmailAddress(ErrorMessage = "Email not valid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Passwod requiered")]
        [StringLength(30, ErrorMessage = "Password min length is 8.", MinimumLength = 8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password again")]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
        public string Password2 { get; set; }

    }
}
