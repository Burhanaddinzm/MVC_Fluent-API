using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Configurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(1, 1);
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
            builder.Property(m => m.Slug).HasColumnType("varchar").HasMaxLength(250).IsRequired();
            builder.Property(m => m.StockKeepingUnit).HasColumnType("varchar").HasMaxLength(150).IsRequired();
            builder.Property(m => m.Description).HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
            builder.Property(m => m.ShortDescription).HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
            builder.Property(m => m.Rate).HasColumnType("decimal").HasPrecision(3, 2).IsRequired();
            builder.Property(m => m.CategoryId).HasColumnType("int").IsRequired();
            builder.Property(m => m.BrandId).HasColumnType("int").IsRequired();

            builder.ConfigureAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("Products");


            builder.HasOne<Category>()
                .WithMany()
                .HasForeignKey(m => m.CategoryId)
                .HasPrincipalKey(m => m.Id)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Brand>()
                .WithMany()
                .HasForeignKey(m => m.BrandId)
                .HasPrincipalKey(m => m.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
