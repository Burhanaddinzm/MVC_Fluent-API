using WebApplication1.Models.Common;

namespace WebApplication1.Models.Entities
{
    public class Category : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ParentId { get; set; }
    }
}
