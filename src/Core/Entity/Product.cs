namespace Core.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Count { get; set; }
    }
}
