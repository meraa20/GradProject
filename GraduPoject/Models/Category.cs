using System.ComponentModel.DataAnnotations;

namespace GraduPoject.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}
