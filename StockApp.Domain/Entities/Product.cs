﻿namespace StockApp.Core.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagUrl { get; set; }
        public double Price { get; set; }



        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
