﻿namespace DesignPatterns.Creationals.Builder.Models
{
    internal sealed class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} ({Price:C})";
        }
    }
}
