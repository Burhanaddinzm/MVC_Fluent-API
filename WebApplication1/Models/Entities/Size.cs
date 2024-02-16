using WebApplication1.Models.Common;

namespace WebApplication1.Models.Entities
{
    public class Size : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string SmallName { get; set; } = null!;
    }
}
