using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vega.Models{
    public class Model{
        public int Id{ get; set; }
        public string Name{ get; set; }
        public int BrandId{ get; set; }
        public Brand Brand{ get; set; }
        public ICollection<Vehicle> Vehicles{ get; set; }

        public Model(){
            Vehicles = new Collection<Vehicle>();
        }
    }
}