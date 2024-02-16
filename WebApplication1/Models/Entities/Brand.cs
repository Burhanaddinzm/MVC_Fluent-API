using WebApplication1.Models.Common;

namespace WebApplication1.Models.Entities
{
    public class Brand : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
