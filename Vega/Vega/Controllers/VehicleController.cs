using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega.Models;
using Vega.Models.ModelResources;
using Vega.Persistence;

namespace Vega.Controllers{
    [Route("/api/vehicles")]
    public class VehicleController : Controller{
        private readonly VegaContext _context;
        private readonly IMapper _mapper;

        public VehicleController(VegaContext context, IMapper mapper){
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] SaveVehicleResource saveVehicleResource){
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var vehicle = _mapper.Map<SaveVehicleResource, Vehicle>(saveVehicleResource);
            vehicle.LastUpdate = DateTime.Now;
            
            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();
            
            var result = _mapper.Map<Vehicle, SaveVehicleResource>(vehicle);
            return Ok(result);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVehicle(int id, [FromBody] SaveVehicleResource saveVehicleResource){
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var vehicle = await _context.Vehicles.Include(v => v.Features)
                .SingleOrDefaultAsync(v => v.Id == id);
            
            if (vehicle == null)
                return NotFound(id);
            
            _mapper.Map(saveVehicleResource, vehicle);
            vehicle.LastUpdate = DateTime.Now;
            
            await _context.SaveChangesAsync();
            
            var result = _mapper.Map<Vehicle, SaveVehicleResource>(vehicle);
            return Ok(result);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id){
            var vehicle = await _context.Vehicles.FindAsync(id);
            
            if (vehicle == null)
                return NotFound(id);
            
            _context.Remove(vehicle);
            await _context.SaveChangesAsync();
            
            return Ok(id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicle(int id){
            var vehicle = await _context.Vehicles
                .Include(v => v.Features)
                .ThenInclude(vf => vf.Feature)
                .Include(v => v.Model)
                .ThenInclude(m => m.Brand)
                .SingleOrDefaultAsync(v => v.Id == id);
            
            if (vehicle == null)
                return NotFound(id);

            var vehicleResource = _mapper.Map<Vehicle, VehicleResource>(vehicle);

            return Ok(vehicleResource);
        }
    }
}