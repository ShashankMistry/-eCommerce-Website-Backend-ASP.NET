namespace eCommerce_Website_Backend_ASP.NET
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public int Quantity { get; set; }
    }

}
