using AppTestActual.Views;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTestActual.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPage : ContentPage
    {
        public DataPage()
        {
            InitializeComponent();

            Debug.WriteLine("DataPage Initalized");
            contentView = new ContentView()
            {
                
                Content = new Label()
                {
                    Text = "hello World",
                    TextColor = Color.Black,
                    
                }
            };
            
            
            Debug.WriteLine(contentView.IsVisible);
            Debug.WriteLine(contentView.HeightRequest);
            //contentView = new VersusBarChartView(
            //    new ViewModels.Stocks.VersusViewModel(
            //        new Models.Stock
            //        {
            //            Id = "0",
            //            Title = "Hello World",
            //            PurchaseTime = new System.DateTime(100000)

            //        },
            //        new AppTestActual.Models.Stock
            //        {
            //            Id = "1",
            //            Title = "Hell",
            //            PurchaseTime = new System.DateTime(10000)
            //        }));

            Debug.WriteLine("-------------------------------Stocks Initalized");
            
        } 
    }
}