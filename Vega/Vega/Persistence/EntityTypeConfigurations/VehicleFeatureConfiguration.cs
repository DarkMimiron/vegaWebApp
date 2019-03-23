using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vega.Models;

namespace Vega.Persistence.EntityTypeConfigurations{
    public class VehicleFeatureConfiguration : IEntityTypeConfiguration<VehicleFeature>{
        public void Configure(EntityTypeBuilder<VehicleFeature> builder){
            builder.HasKey(vf =>
                new{vf.VehicleId, vf.FeatureId}
            );

            builder.HasOne(vf => vf.Vehicle)
                .WithMany(v => v.Features)
                .HasForeignKey(vf => vf.VehicleId);

            builder.HasOne(vf => vf.Feature)
                .WithMany(f => f.Vehicles)
                .HasForeignKey(vf => vf.FeatureId);
        }
    }
}