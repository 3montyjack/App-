using System.Collections.Generic;
using System.Threading.Tasks;
using AppTestActual.Models;
using Xamarin.Forms;

namespace AppTestActual.Services
{
    public class StockDataService
    {
        private readonly IDataStore<StockDatum> _dataStore = DependencyService.Get<IDataStore<StockDatum>>();

        public StockDataService()
        {
        }

        public bool IsBusy { get; private set; } = false;

        /// <summary>
        /// Loads the stocks from the datastore
        /// </summary>
        /// <param name="id">the id of the stock data </param>
        /// <returns></returns>
        public async Task<IEnumerable<StockDatum>> ExecuteLoadTask(string id)
        {
            // Signify that the service is busy
            IsBusy = true;

            // Begin asyncronous await
            var returnList = await _dataStore.GetItemsAsync();

            // Signify that the service is ready
            IsBusy = false;

            return (IEnumerable<StockDatum>)returnList;
        }
    }
}
