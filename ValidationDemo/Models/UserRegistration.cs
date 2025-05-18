using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ValidationDemo.Models
{
    public class UserRegistration
    {
        [Display (Name ="UserName")]
        [Required(ErrorMessage ="UserName is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 20 characters")]
        [RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "Username can only contain letters, numbers, underscores and hyphens")]
        [Remote (action: "checkUserName",controller: "Account", ErrorMessage = "This username is already taken")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
           ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "ConfiraPasswored")]
        [Required(ErrorMessage = "ConfiranPasswored is required")]
        [Compare("Password", ErrorMessage = "The Password and Confirmation password do not match!")]
        public string ConfiranPasswored { get; set; }

        [Display(Name = "PhoneNumber")]
        [Required(ErrorMessage = "PhoneNumber is required")]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
            ErrorMessage = "Phone number format: (123) 456-7890 or 123-456-7890")]
        public string PhoneNumber { get; set; }

    }
}
