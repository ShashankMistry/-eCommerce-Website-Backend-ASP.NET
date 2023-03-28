namespace eCommerce_Website_Backend_ASP.NET
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Email { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public string Image { get; set; }
    }
}
