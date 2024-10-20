using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GraduPoject.Models
{
    public class IdUser : IdentityUser
    {
        public virtual User? User { get; set; }
        public virtual Admin? Admin { get; set; }
        public virtual BusinessOwner? BusinessOwner { get; set; }


    }
}
