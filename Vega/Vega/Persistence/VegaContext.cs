using Microsoft.EntityFrameworkCore;
using Vega.Models;
using Vega.Persistence.EntityTypeConfigurations;

namespace Vega.Persistence{
    public class VegaContext : DbContext{
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Model> Models{ get; set; }
        public DbSet<Feature> Features{ get; set; }
        
        public VegaContext(DbContextOptions options)
            : base(options){
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new ModelConfiguration());
            modelBuilder.ApplyConfiguration(new FeatureConfiguration());
        }
    }
}