using Front_to_Back.Models.Base;

namespace Front_to_Back.Models
{
    public class Blog : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
    }
}
