using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewWilliamExpress.Server.Data;
using WilliamExpress.Shared.Domain;
using System.Security.Claims;
using System;
using NewWilliamExpress.Server.Models;
using Microsoft.AspNetCore.Identity;

namespace WilliamExpress.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingaddressesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public ShippingaddressesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: api/Shippingaddresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shippingaddress>>> GetShippingaddress()
        {
            return await _context.Shippingaddress.ToListAsync();
        }

        // GET: api/Shippingaddresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Shippingaddress>> GetShippingaddress(int id)
        {
            var shippingaddress = await _context.Shippingaddress.FindAsync(id);

            if (shippingaddress == null)
            {
                return NotFound();
            }

            return shippingaddress;
        }

        // PUT: api/Shippingaddresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShippingaddress(int id, Shippingaddress shippingaddress)
        {
            if (id != shippingaddress.Id)
            {
                return BadRequest();
            }

            _context.Entry(shippingaddress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShippingaddressExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Shippingaddresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Shippingaddress>> PostShippingaddress(Shippingaddress shippingaddress)
        {
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);
            shippingaddress.DateCreated = DateTime.Now;
            shippingaddress.CreatedBy = user.UserName;

            _context.Shippingaddress.Add(shippingaddress);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShippingaddress", new { id = shippingaddress.Id }, shippingaddress);
        }

        // DELETE: api/Shippingaddresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShippingaddress(int id)
        {
            var shippingaddress = await _context.Shippingaddress.FindAsync(id);
            if (shippingaddress == null)
            {
                return NotFound();
            }

            _context.Shippingaddress.Remove(shippingaddress);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShippingaddressExists(int id)
        {
            return _context.Shippingaddress.Any(e => e.Id == id);
        }
    }
}
