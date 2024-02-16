using WebApplication1.Models.Common;

namespace WebApplication1.Models.Entities
{
    public class BlogPost : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
        public int CategoryId { get; set; }
        public DateTime PublishedAt { get; set; }
        public int PublishedBy { get; set; }
    }
}
