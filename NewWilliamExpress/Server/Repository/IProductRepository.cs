using System.Threading.Tasks;
using WilliamExpress.Server.Paging;
using WilliamExpress.Shared.Domain;
using WilliamExpress.Shared.RequestParameters;

namespace WilliamExpress.Server.Repository
{
    public interface IItemRepository
    {
        Task<PagedList<Item>> GetItems(ItemParameters itemParameters);
    }
}
