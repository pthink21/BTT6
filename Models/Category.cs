using System.ComponentModel.DataAnnotations;

namespace BTT6.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Tên chủ đề không được để trống")]
        [Display(Name = "Tên chủ đề")]
        public string CategoryName { get; set; } = string.Empty;

        [Display(Name = "Mô tả")]
        public string? Description { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
