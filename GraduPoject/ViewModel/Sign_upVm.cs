using System.ComponentModel.DataAnnotations;

namespace GraduPoject.ViewModel
{
    public class Sign_upVm
    {
        public int ID { get; set; }

        [ StringLength(30, MinimumLength = 10)]
        
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; } 

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string Confirmpassword { get; set; }
    }
}
