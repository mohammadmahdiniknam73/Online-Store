namespace Market.Entitys
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid CategoryId { get; set; }
    }
}
