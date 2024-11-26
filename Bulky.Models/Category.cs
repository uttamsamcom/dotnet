using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")] //show the name ONLY on UI
        public string Name { get; set; }
        [DisplayName("Display Order")] //show the name ONLY on UI
        [Range(1, 100, ErrorMessage = "Display order must between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
