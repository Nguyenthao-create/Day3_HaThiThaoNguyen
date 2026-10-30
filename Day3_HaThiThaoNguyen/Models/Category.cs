using System.ComponentModel.DataAnnotations;

namespace Day3_HaThiThaoNguyen.Models
{
    public class Category
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; } = String.Empty;
        // Navigation property to Products
        public List<Product> Products { get; set; }// hien thi danh sach san pham thuoc category

    }
}
