using System.ComponentModel.DataAnnotations;

namespace EmptyBlazorApp1.Models
{
    public class LoginAccountForm
    {
        [Required(ErrorMessage = "Provide email.")]
        [EmailAddress(ErrorMessage = "Email not valid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password requiered.")]
        public string Password { get; set; }

    }
}
