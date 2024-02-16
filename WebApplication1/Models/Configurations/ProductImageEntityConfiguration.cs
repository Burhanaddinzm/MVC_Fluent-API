using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Configurations
{
    public class ProductImageEntityConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(1, 1);
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(m => m.IsMain).HasColumnType("bit").IsRequired();
            builder.Property(m => m.ProductId).HasColumnType("int").IsRequired();

            builder.HasKey(m => m.Id);
            builder.ToTable("ProductImages");

            builder.HasOne<Product>()
                .WithMany()
                .HasForeignKey(m => m.ProductId)
                .HasPrincipalKey(m => m.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
