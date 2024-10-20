using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraduPoject.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        [ForeignKey("IdUser")]
        public string useid { get; set; }
        public IdUser IdUser { get; set; }

    }
}
