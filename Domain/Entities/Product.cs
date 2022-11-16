﻿using Domain.Common;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}
