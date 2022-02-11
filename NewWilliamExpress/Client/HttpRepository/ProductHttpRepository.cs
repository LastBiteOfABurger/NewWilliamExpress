using BlazorProducts.Client.Features;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WilliamExpress.Shared.Domain;
using WilliamExpress.Shared.RequestFeatures;
using WilliamExpress.Shared.RequestParameters;

namespace NewWilliamExpress.Client.HttpRepository
{
    public class ItemHttpRepository : IItemHttpRepository
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public ItemHttpRepository(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<PagingResponse<Item>> GetItems(ItemParameters itemParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = itemParameters.PageNumber.ToString(),
                ["searchTerm"] = itemParameters.SearchTerm == null ? "" : itemParameters.SearchTerm,
                ["orderBy"] = itemParameters.OrderBy
            };
            var response = await _client.GetAsync(QueryHelpers.AddQueryString("api/items", queryStringParam));
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var pagingResponse = new PagingResponse<Item>
            {
                Items = JsonSerializer.Deserialize<List<Item>>(content, _options),
                MetaData = JsonSerializer.Deserialize<MetaData>(response.Headers.GetValues("X-Pagination").First(), _options)
            };

            return pagingResponse;
        }
        public async Task<string> UploadProductImage(MultipartFormDataContent content)
        {
            var postResult = await _client.PostAsync("https://localhost:44376/api/upload", content);
            var postContent = await postResult.Content.ReadAsStringAsync();
            if (!postResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(postContent);
            }
            else
            {
                var Image = Path.Combine("https://localhost:44376/", postContent);
                return Image;
            }
        }
    }
}
