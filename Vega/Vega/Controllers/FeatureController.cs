using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega.Models;
using Vega.Models.ModelResources;
using Vega.Persistence;

namespace Vega.Controllers{
    public class FeatureController{
        private readonly VegaContext _context;
        private readonly IMapper _mapper;
        
        public FeatureController(VegaContext context, IMapper mapper){
            _context = context;
            _mapper = mapper;
        }
        
        [HttpGet("api/features")]
        public async Task<IEnumerable<KeyValuePairResource>> GetFeatures(){
            var feature = await _context.Features.ToListAsync();
            
            return _mapper.Map<List<Feature>, List<KeyValuePairResource>>(feature);
        }
    }
}