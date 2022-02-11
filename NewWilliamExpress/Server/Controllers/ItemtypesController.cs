using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewWilliamExpress.Server.Data;
using WilliamExpress.Shared.Domain;

namespace WilliamExpress.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemtypesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ItemtypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Itemtypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Itemtype>>> GetItemtype()
        {
            return await _context.Itemtype.ToListAsync();
        }

        // GET: api/Itemtypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Itemtype>> GetItemtype(int id)
        {
            var itemtype = await _context.Itemtype.FindAsync(id);

            if (itemtype == null)
            {
                return NotFound();
            }

            return itemtype;
        }

        // PUT: api/Itemtypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemtype(int id, Itemtype itemtype)
        {
            if (id != itemtype.Id)
            {
                return BadRequest();
            }

            _context.Entry(itemtype).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemtypeExists(id))
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

        // POST: api/Itemtypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Itemtype>> PostItemtype(Itemtype itemtype)
        {
            _context.Itemtype.Add(itemtype);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemtype", new { id = itemtype.Id }, itemtype);
        }

        // DELETE: api/Itemtypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemtype(int id)
        {
            var itemtype = await _context.Itemtype.FindAsync(id);
            if (itemtype == null)
            {
                return NotFound();
            }

            _context.Itemtype.Remove(itemtype);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemtypeExists(int id)
        {
            return _context.Itemtype.Any(e => e.Id == id);
        }
    }
}
