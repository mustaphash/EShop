namespace Core.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
