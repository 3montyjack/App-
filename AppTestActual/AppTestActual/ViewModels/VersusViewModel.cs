using System;
using System.Diagnostics;
using System.Threading.Tasks;
using AppTestActual.Helpers;
using AppTestActual.Models;
using AppTestActual.Services;
using Xamarin.Forms;

namespace AppTestActual.ViewModels.Stocks
{
    public class VersusViewModel
    {
        private readonly IDataStore<StockDatum> _service = DependencyService.Get<IDataStore<StockDatum>>();

        public VersusViewModel(Stock stockOne, Stock stockTwo)
        {
            Title = stockOne.Title + " vs " + stockTwo.Title;
            TimeSpan = stockOne.PurchaseTime + " - " + "Today";
            Debug.WriteLine("-------------------------------ViewModel Initalized");
            StockOne = stockOne;
            StockTwo = stockTwo;

            StockOneData = new ObservableRangeCollection<StockDatum>();
            StockTwoData = new ObservableRangeCollection<StockDatum>();

            LoadItemsCommand = new Command(async () => await ExecuteLoadStockDataCommand());
            LoadItemsCommand.Execute(null);
        }

        public Stock StockOne { get; set; }
        public Stock StockTwo { get; set; }
        public ObservableRangeCollection<StockDatum> StockOneData { get; set; }
        public ObservableRangeCollection<StockDatum> StockTwoData { get; set; }
        public Command LoadItemsCommand { get; set; }
        public string TimeSpan { get; set; }
        public string Title { get; set; }



        private async Task ExecuteLoadStockDataCommand()
        {

            try
            {
                StockOneData.Clear();
                StockTwoData.Clear();

                var stockOneData = await _service.GetItemsAsync(StockOne.Id);
                var stockTwoData = await _service.GetItemsAsync(StockTwo.Id);

                StockOneData.ReplaceRange(stockOneData);
                StockTwoData.ReplaceRange(stockTwoData);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
