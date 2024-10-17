
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
         public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        [MaxLength(100)]    
        public string Name { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Display Order must be greater than 0.")]
        public int DisplayOrder {  get; set; }  
    }
}
