using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vega.Models;

namespace Vega.Persistence.EntityTypeConfigurations{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>{
        public void Configure(EntityTypeBuilder<Brand> builder){
            builder.ToTable("Brand");
            
            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasMany(b => b.Models)
                .WithOne(m => m.Brand)
                .HasForeignKey(b => b.BrandId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}