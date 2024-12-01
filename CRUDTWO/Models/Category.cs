using System.ComponentModel.DataAnnotations;

namespace CRUDTWO.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]

        public int DisplayOrder { get; set; }

    }
}
