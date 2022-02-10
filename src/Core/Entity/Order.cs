namespace Core.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int ProductId { get; set; }
        public int ClientId { get; set; }

        public Shop Shop { get; set; }
        public Product Product { get; set; }
        public Client Client { get; set; }
    }
}
