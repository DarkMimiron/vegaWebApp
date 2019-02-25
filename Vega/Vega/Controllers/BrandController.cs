using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega.Models;
using Vega.Models.ModelResources;
using Vega.Persistence;

namespace Vega.Controllers{
    public class BrandController{
        private readonly VegaContext _context;
        private readonly IMapper _mapper;

        public BrandController(VegaContext context, IMapper mapper){
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("api/brands")]
        public async Task<IEnumerable<BrandResource>> GetBrands(){
            var brands = await _context.Brands
                .Include(b => b.Models)
                .ToListAsync();
            
            return _mapper.Map<List<Brand>, List<BrandResource>>(brands);
        }
    }
}