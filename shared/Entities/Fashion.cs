using book_api.Entities;

namespace fashion_api.Entities
{
    public class Fashion : AuditableEntity
    {
        public string Description { get; set; }
        public string Size { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
    }
}