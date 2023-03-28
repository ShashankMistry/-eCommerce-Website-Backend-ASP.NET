namespace eCommerce_Website_Backend_ASP.NET
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Total { get; set; }
        public int Quantity { get; set; }
    }
}
