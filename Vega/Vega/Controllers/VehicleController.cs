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
        public async Task<IActionResult> CreateVehicle([FromBody] VehicleResource vehicleResource){
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var vehicle = _mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            vehicle.LastUpdate = DateTime.Now;
            
            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();
            
            var result = _mapper.Map<Vehicle, VehicleResource>(vehicle);
            return Ok(result);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVehicle(int id, [FromBody] VehicleResource vehicleResource){
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var vehicle = await _context.Vehicles.Include(v => v.Features)
                .SingleOrDefaultAsync(v => v.Id == id); 
            _mapper.Map(vehicleResource, vehicle);
            vehicle.LastUpdate = DateTime.Now;
            
            await _context.SaveChangesAsync();
            
            var result = _mapper.Map<Vehicle, VehicleResource>(vehicle);
            return Ok(result);
        }
    }
}