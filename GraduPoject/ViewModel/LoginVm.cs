using System.ComponentModel.DataAnnotations;

namespace GraduPoject.ViewModel
{
    public class LoginVm
    {
        public int ID { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
