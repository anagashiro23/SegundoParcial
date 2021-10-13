using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SegundoParcialAndresNagashiro.Data;
using SegundoParcialAndresNagashiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAndresNagashiro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        private readonly AppDbContext _context;
        public RandomController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<Naipe>> GetDato()
        {
            var list = await _context.Naipes.ToListAsync();
            var max = list.Count;
            int index = new Random().Next(0, max);
            var dato = list[index];
            if (dato == null)
            {
                return NoContent();
            }
            return dato;
        }
    }
}
