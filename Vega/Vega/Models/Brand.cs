using System.Collections.Generic;

namespace Vega.Models{
    public class Brand{
        public int Id{ get; set; }
        public string Name{ get; set; }
        public IEnumerable<Model> Models{ get; set; }

        public Brand(){
            Models = new List<Model>();
        }
    }
}