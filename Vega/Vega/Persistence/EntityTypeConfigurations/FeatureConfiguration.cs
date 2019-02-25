using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vega.Models;

namespace Vega.Persistence.EntityTypeConfigurations{
    public class FeatureConfiguration : IEntityTypeConfiguration<Feature>{
        public void Configure(EntityTypeBuilder<Feature> builder){
            builder.ToTable("Feature");
            
            builder.Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}