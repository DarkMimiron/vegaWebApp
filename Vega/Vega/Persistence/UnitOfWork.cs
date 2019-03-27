using System.Threading.Tasks;
using Vega.Core;

namespace Vega.Persistence{
    public class UnitOfWork : IUnitOfWork{
        private readonly VegaContext _context;

        public UnitOfWork(VegaContext context){
            _context = context;
        }
        
        public async Task CompleteAsync(){
            await _context.SaveChangesAsync();
        }
    }
}