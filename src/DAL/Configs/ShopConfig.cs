using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class ShopConfig : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name).HasMaxLength(250).IsRequired();
            builder.Property(s => s.Place).IsRequired();
            builder.Property(s => s.PhoneNumber).IsRequired();
            builder.Property(s => s.OpeningDate).IsRequired();
        }
    }
}
