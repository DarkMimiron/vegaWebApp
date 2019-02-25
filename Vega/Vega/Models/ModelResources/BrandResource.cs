using System.Collections.Generic;

namespace Vega.Models.ModelResources{
    public class BrandResource{
        public int Id{ get; set; }
        public string Name{ get; set; }
        public IEnumerable<ModelResource> Models{ get; set; }
    }
}