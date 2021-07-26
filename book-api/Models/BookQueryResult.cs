using System;

namespace book_api.Models
{
    public class BookQueryResult
    {
        public Guid Id { get; set; }
        public DateTime CreateAt { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public uint TotalPages { get; set; }
    }
}