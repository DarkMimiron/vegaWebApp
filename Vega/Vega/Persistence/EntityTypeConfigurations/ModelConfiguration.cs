using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vega.Models;

namespace Vega.Persistence.EntityTypeConfigurations{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>{
        public void Configure(EntityTypeBuilder<Model> builder){
            builder.ToTable("Model");
            
            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(m => m.BrandId)
                .IsRequired();

            builder.HasMany(m => m.Vehicles)
                .WithOne(v => v.Model)
                .HasForeignKey(m => m.ModelId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}