namespace Day3_HaThiThaoNguyen.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = String.Empty;
        // Foreign key to Category
        public int CategoryId { get; set; }
        // Navigation property to Category
        public Category? Category { get; set; } 
    }
}
