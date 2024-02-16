using WebApplication1.Models.Common;

namespace WebApplication1.Models.Entities
{
    public class Product : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string StockKeepingUnit { get; set; } = null!;
        public string ShortDescription { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Rate { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
    }
}
