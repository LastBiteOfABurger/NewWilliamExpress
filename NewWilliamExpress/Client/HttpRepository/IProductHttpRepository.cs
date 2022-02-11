using BlazorProducts.Client.Features;
using System.Net.Http;
using System.Threading.Tasks;
using WilliamExpress.Shared.Domain;
using WilliamExpress.Shared.RequestParameters;

namespace NewWilliamExpress.Client.HttpRepository
{
    public interface IItemHttpRepository
    {
        Task<PagingResponse<Item>> GetItems(ItemParameters itemParameters);
        Task<string> UploadProductImage(MultipartFormDataContent content);

    }
}
