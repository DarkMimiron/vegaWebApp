using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vega.Models;

namespace Vega.Persistence.EntityTypeConfigurations{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>{
        public void Configure(EntityTypeBuilder<Vehicle> builder){
            builder.ToTable("Vehicle");

            builder.Property(v => v.ContactName)
                .IsRequired()
                .HasMaxLength(255);
            
            builder.Property(v => v.ContactEmail)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(v => v.ContactPhone)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}