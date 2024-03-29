﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using NewWilliamExpress.Server.Data;
using WilliamExpress.Server.Repository;
using WilliamExpress.Shared.Domain;
using WilliamExpress.Shared.RequestParameters;
using System;
using NewWilliamExpress.Server.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace WilliamExpress.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IItemRepository _repo;
        private UserManager<ApplicationUser> _userManager;

        public ItemsController(ApplicationDbContext context, IItemRepository repo, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
            _repo = repo;
        }

        //public ItemsController(IItemRepository repo)
        //{
        //    _repo = repo;
        //}
        //GET: api/Items
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Item>>> GetItems()
        //{
        //    return await _context.Items.ToListAsync();
        //}

        public async Task<IActionResult> Get([FromQuery] ItemParameters itemParameters)
        {
            var items = await _repo.GetItems(itemParameters);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(items.MetaData));

            return Ok(items);
        }



        // GET: api/Items/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {
            var item = await _context.Items.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }


        // PUT: api/Items/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(int id, Item item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(id))
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

        // POST: api/Items
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Item>> PostItem(Item item)
        {
            //Add createdDate and createdBy to the taskItem.
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);
            item.DateCreated = DateTime.Now;
            item.CreatedBy = user.UserName;

            _context.Items.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItem", new { id = item.Id }, item);
        }

        // DELETE: api/Items/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.Id == id);
        }
    }
}
