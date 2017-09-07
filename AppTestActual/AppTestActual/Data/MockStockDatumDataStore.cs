using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppTestActual.Models;
using AppTestActual.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(MockStockDatumDataStore))]
namespace AppTestActual.Services
{
    class MockStockDatumDataStore : IDataStore<StockDatum>
    {
        private Random random = new Random();
        private bool isInitialized;
        private List<StockDatum> items;

        public async Task<bool> AddItemAsync(StockDatum item)
        {
            await InitializeAsync();

            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(StockDatum item)
        {
            await InitializeAsync();

            var _item = items.Where(arg => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(StockDatum item)
        {
            await InitializeAsync();

            var _item = items.Where(arg => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<StockDatum> GetItemAsync(string id)
        {
            await InitializeAsync();

            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<StockDatum>> GetItemsAsync(string id = null)
        {
            await InitializeAsync();

            return await Task.FromResult(items.FindAll(s => s.ParentId == id));
        }

        public Task<bool> PullLatestAsync()
        {
            return Task.FromResult(true);
        }

        public Task<bool> SyncAsync()
        {
            return Task.FromResult(true);
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task InitializeAsync()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            if (isInitialized)
                return;

            items = new List<StockDatum>();
            var _items = new List<StockDatum>();

            for (int i1 = 0; i1 <= 6; i1++)
            {
                for (int i2 = 1; i2 <= 12; i2++)
                {
                    _items.Add(new StockDatum
                    {
                        DateTime = new DateTime(2017, i2, 1),
                        Price = (decimal)random.NextDouble() * 100,
                        ParentId = Convert.ToString(i1)
                    });
                }
            }

            foreach (var item in _items)
                items.Add(item);

            isInitialized = true;
        }
    }
}
