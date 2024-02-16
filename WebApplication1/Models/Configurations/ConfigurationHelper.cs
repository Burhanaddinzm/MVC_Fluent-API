using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Common;

namespace WebApplication1.Models.Configurations
{
    public static class ConfigurationHelper
    {
        public static void ConfigureAuditable<T>(this EntityTypeBuilder<T> builder)
            where T : AuditableEntity
        {
            builder.Property(m => m.CreatedAt).HasColumnType("datetime2").IsRequired();
            builder.Property(m => m.CreatedBy).HasColumnType("int");

            builder.Property(m => m.ModifiedAt).HasColumnType("datetime2");
            builder.Property(m => m.ModifiedBy).HasColumnType("int");

            builder.Property(m => m.DeletedAt).HasColumnType("datetime2");
            builder.Property(m => m.DeletedBy).HasColumnType("int");
        }
    }
}
