using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vega.Models.ModelResources{
    public class BrandResource : KeyValuePairResource{
        public ICollection<KeyValuePairResource> Models{ get; set; }

        public BrandResource(){
            Models = new Collection<KeyValuePairResource>();
        }
    }
}