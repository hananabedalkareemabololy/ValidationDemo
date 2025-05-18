using System.ComponentModel.DataAnnotations;

namespace ValidationDemo.Models
{
    public class UserLogin
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50,MinimumLength =3 ,ErrorMessage ="Username must be between 3 and 50 characters")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Passwored is required")]
        [DataType(DataType.Password)]
        [StringLength(100,MinimumLength =6, ErrorMessage = "Passwored must be at least 6 characters")]
        [Display(Name="UserPasswored")]
        public string Password { get; set; }
        
        [Display(Name = "Remember Me")]
        public bool Remember { get; set; }
    }
}
