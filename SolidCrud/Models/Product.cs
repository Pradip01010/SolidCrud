﻿using Microsoft.EntityFrameworkCore;

namespace SolidCrud.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Precision(18, 2)]
        public decimal Price { get; set; }

    }
}
