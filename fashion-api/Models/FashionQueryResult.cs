using System;

namespace fashion_api.Models
{
    public class FashionQueryResult
    {
        public Guid Id { get; set; }
        public DateTime CreateAt { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
    }
}