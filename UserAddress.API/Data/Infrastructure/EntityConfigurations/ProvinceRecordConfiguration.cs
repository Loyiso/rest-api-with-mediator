using UserAddress.API.Data.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UserAddress.API.Data.Infrastructure.EntityConfigurations
{
    public class ProvinceRecordConfiguration : IEntityTypeConfiguration<ProvinceRecord>
    {
        public void Configure(EntityTypeBuilder<ProvinceRecord> builder)
        {
            builder.ToTable("ProvinceRecord");

            builder.HasKey(ci => ci.Id); 
        }
    }
}
