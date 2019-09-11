using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalendarEvent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalendarEvent.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly Cal_DBContext _context;

        public ValuesController(Cal_DBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetDetails()
        {
            var details = await _context.TblCalevent.ToListAsync();
            return Ok(details);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            var details = await _context.TblCalevent.FirstOrDefaultAsync(x => x.Id== id);
            return Ok(details);
        }

    }
}
