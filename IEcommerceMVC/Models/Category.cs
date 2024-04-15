using System.ComponentModel.DataAnnotations;

namespace IEcommerceMVC.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
    }
}
