using book_api.Entities;

namespace electronic_api.Entities
{
    public class Phone : AuditableEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}