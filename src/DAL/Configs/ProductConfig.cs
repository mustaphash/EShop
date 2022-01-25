using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).HasMaxLength(250).IsRequired();
            builder.Property(p => p.Size).IsRequired();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Color).IsRequired();
            builder.Property(p => p.ManufactureDate).IsRequired();
            builder.Property(p => p.Count).IsRequired();
        }
    }
}
