using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using NewWilliamExpress.Server.Data;
using WilliamExpress.Server.Paging;
using WilliamExpress.Server.Repository.RepositoryExtensions;
using WilliamExpress.Shared.Domain;
using WilliamExpress.Shared.RequestParameters;

namespace WilliamExpress.Server.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationDbContext _context;

        public ItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PagedList<Item>> GetItems(ItemParameters itemParameters)
        {
            var items = await _context.Items
                .Search(itemParameters.SearchTerm)
                .Sort(itemParameters.OrderBy)
                .ToListAsync();

            return PagedList<Item>
                .ToPagedList(items, itemParameters.PageNumber, itemParameters.PageSize);
        }
    }
}
