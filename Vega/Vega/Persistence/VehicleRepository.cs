using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vega.Core;
using Vega.Models;

namespace Vega.Persistence{
    public class VehicleRepository : IVehicleRepository{
        private readonly VegaContext _context;

        public VehicleRepository(VegaContext context){
            _context = context;
        }
        
        public async Task<Vehicle> GetVehicle(int id, bool includeRelated = true){
            if (!includeRelated)
                return await _context.Vehicles.FindAsync(id);
            
            return await _context.Vehicles
                .Include(v => v.Features)
                .ThenInclude(vf => vf.Feature)
                .Include(v => v.Model)
                .ThenInclude(m => m.Brand)
                .SingleOrDefaultAsync(v => v.Id == id);
        }

        public void Add(Vehicle vehicle){
            _context.Vehicles.Add(vehicle);
        }

        public void Remove(Vehicle vehicle){
            _context.Remove(vehicle);
        }
    }
}