using System.Collections.Generic;
using WilliamExpress.Shared.RequestFeatures;

namespace BlazorProducts.Client.Features
{
    public class PagingResponse<T> where T : class
    {
        public List<T> Items { get; set; }
        public MetaData MetaData { get; set; }
    }
}
