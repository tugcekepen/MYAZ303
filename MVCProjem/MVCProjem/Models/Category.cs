using System.ComponentModel.DataAnnotations;

namespace MVCProjem.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Category Name is required.")]
        public String? CategoryName { get; set; }
        public String? Description { get; set; }

        public Category()
        {

        }

        public Category(int id, String categoryName)
        {
            Id = id;
            CategoryName = categoryName;
        }
    }
}
