using Front_to_Back.Models.Base;

namespace Front_to_Back.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int Order { get; set; }

    }
}
