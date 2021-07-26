using System;

namespace electronic_api.Models
{
    public class PhoneQueryResult
    {
        public Guid Id { get; set; }
        public DateTime CreateAt { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}