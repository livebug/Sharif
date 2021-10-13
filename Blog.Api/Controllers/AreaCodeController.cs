using Blog.Api.Contexts;
using Blog.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaCodeController : ControllerBase
    {
        private ShadbContext _context;
        private ILogger<AreaCodeController> _logger;
        public AreaCodeController(ShadbContext context, ILogger<AreaCodeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("top")]
        public async Task<IEnumerable<AreaCode>> GetTopType()
        {
            return await _context.AreaCodes.Where(x => x.Type == "1").ToListAsync();
        }

        [HttpGet("{code}/subs")]
        public async Task<IEnumerable<AreaCode>> GetSubs(string code)
        {
            return await _context.AreaCodes.Where(x => x.ParentCode == code).ToListAsync();
        }
    }
}
