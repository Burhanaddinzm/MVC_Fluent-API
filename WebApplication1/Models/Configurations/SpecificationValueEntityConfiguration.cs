using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Configurations
{
    public class SpecificationValueEntityConfiguration : IEntityTypeConfiguration<SpecificationValue>
    {
        public void Configure(EntityTypeBuilder<SpecificationValue> builder)
        {
            builder.Property(m => m.ProductId).HasColumnType("int");
            builder.Property(m => m.SpecificationId).HasColumnType("int");
            builder.Property(m => m.Value).HasColumnType("nvarchar").HasMaxLength(150).IsRequired();

            builder.HasKey(m => new { m.ProductId, m.SpecificationId });// Composite Primary Key
            builder.ToTable("SpecificationValues");

            builder.HasOne<Specification>()
                .WithMany()
                .HasPrincipalKey(m => m.Id)
                .HasForeignKey(m => m.SpecificationId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Product>()
                .WithMany()
                .HasPrincipalKey(m => m.Id)
                .HasForeignKey(m => m.ProductId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
