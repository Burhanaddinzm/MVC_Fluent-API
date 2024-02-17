namespace WebApplication1.Models.Entities
{
    public class SpecificationValue
    {
        public int ProductId { get; set; }
        public int SpecificationId { get; set; }
        public string Value { get; set; } = null!;
    }
}
