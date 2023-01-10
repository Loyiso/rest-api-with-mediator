using UserAddress.API.Data.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UserAddress.API.Data.Infrastructure.EntityConfigurations
{
    public class AddressRecordConfiguration : IEntityTypeConfiguration<AddressRecord>
    {
        public void Configure(EntityTypeBuilder<AddressRecord> builder)
        {
            builder.ToTable("AddressRecord");

            builder.HasKey(ci => ci.Id); 
        }
    }
}
