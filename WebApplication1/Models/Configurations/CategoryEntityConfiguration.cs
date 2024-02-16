using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(1, 1);
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(m => m.ParentId).HasColumnType("int").IsRequired();

            builder.ConfigureAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("Categories");

            builder.HasOne<Category>()
                .WithMany()
                .HasForeignKey(m => m.ParentId)
                .HasPrincipalKey(m => m.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
