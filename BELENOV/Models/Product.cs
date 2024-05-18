using System.ComponentModel.DataAnnotations;

namespace BELENOV.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
    }
}
