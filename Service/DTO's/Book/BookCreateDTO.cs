﻿namespace Service.DTO_s.Book
{
    public class BookCreateDTO
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}
