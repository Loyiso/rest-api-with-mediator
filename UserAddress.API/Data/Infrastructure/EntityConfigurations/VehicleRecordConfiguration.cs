using UserAddress.API.Data.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UserAddress.API.Data.Infrastructure.EntityConfigurations
{
    public class VehicleRecordConfiguration : IEntityTypeConfiguration<VehicleRecord>
    {
        public void Configure(EntityTypeBuilder<VehicleRecord> builder)
        {
            builder.ToTable("VehicleRecord");

            builder.HasKey(ci => ci.Id); 
        }
    }
}
