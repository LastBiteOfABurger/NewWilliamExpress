//using Microsoft.AspNetCore.Components;
//using BlazorProducts.Client.HttpRepository;
//using Shared.RequestParameters;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using WilliamExpress.Shared.Domain;
//using Shared.RequestFeatures;

//namespace WilliamExpress.Client.Pages.Main
//{
//    public partial class Index
//    {
//        public List<Item> ItemList { get; set; } = new List<Item>();
//        public MetaData MetaData { get; set; } = new MetaData();

//        private ItemParameters _itemParameters = new ItemParameters();

//        [Inject]
//        public IItemHttpRepository ItemRepo { get; set; }

//        private async Task SelectedPage(int page)
//        {
//            _itemParameters.PageNumber = page;
//            await GetItems();
//        }

//        private async Task GetItems()
//        {
//            var pagingResponse = await ItemRepo.GetItems(_itemParameters);
//            ItemList = pagingResponse.Items;
//            MetaData = pagingResponse.MetaData;
//        }
//        private async Task SearchChanged(string searchTerm)
//        {
//            Console.WriteLine(searchTerm);
//            _itemParameters.PageNumber = 1;
//            _itemParameters.SearchTerm = searchTerm;
//            await GetItems();
//        }

//    }
//}
