using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Configurations
{
    public class BlogPostEntityConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(1, 1);
            builder.Property(m => m.Title).HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
            builder.Property(m => m.Slug).HasColumnType("varchar").HasMaxLength(150).IsRequired();
            builder.Property(m => m.Body).HasColumnType("varchar(max)").IsRequired();
            builder.Property(m => m.ImagePath).HasColumnType("varchar").HasMaxLength(80).IsRequired();
            builder.Property(m => m.CategoryId).HasColumnType("int").IsRequired();
            builder.Property(m => m.PublishedAt).HasColumnType("datetime2").IsRequired();
            builder.Property(m => m.PublishedBy).HasColumnType("int").IsRequired();

            builder.ConfigureAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("BlogPosts");

            builder.HasOne<Category>()
                .WithMany()
                .HasForeignKey(m => m.CategoryId)
                .HasPrincipalKey(m => m.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
