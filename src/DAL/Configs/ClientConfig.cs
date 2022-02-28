using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.FirstName).HasMaxLength(250).IsRequired();
            builder.Property(c => c.LastName).HasMaxLength(250).IsRequired();
            builder.Property(c => c.Adress).IsRequired();
            builder.Property(c => c.Gender).IsRequired();
            builder.Property(c => c.BirthDate).IsRequired();
        }
    }
}
