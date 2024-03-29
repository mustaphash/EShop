﻿namespace Core.Entity
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime OpeningDate { get; set; }
        public ICollection<Product> ProductI{ get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
