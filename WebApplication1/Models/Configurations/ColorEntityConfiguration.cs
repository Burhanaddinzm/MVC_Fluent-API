using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Configurations
{
    public class ColorEntityConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(1, 1);
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(m => m.HexCode).HasColumnType("varchar").HasMaxLength(9).IsRequired();

            builder.ConfigureAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("Colors");
        }
    }
}
