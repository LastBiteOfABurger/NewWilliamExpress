using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using NewWilliamExpress.Server.Data;

namespace NewWilliamExpress.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AccountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieve all the users
        /// </summary>
        /// <returns>ApplicationUsers in a List</returns>
        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            var usersList = await _context.ApplicationUsers.ToListAsync();
            return Ok(usersList);
        }
    }
}
