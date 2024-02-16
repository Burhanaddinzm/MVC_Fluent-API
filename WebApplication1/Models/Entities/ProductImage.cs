namespace WebApplication1.Models.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsMain { get; set; }
        public int ProductId { get; set; }
    }
}
