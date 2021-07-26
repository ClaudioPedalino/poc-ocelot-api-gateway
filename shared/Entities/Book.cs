﻿namespace book_api.Entities
{
    public class Book : AuditableEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public uint TotalPages { get; set; }
    }
}