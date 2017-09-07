using AppTestActual.ViewModels.Stocks;
using System.Diagnostics;
using Xamarin.Forms;

namespace AppTestActual.Views
{
    public partial class VersusBarChartView : ContentView
    {
        readonly VersusViewModel viewModel;

        public VersusBarChartView(VersusViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
            Debug.WriteLine("Ha Ha Ha");
            Debug.WriteLine(viewModel.StockOneData.Count);
            grid.ColumnSpacing = 0.0;
            grid.Children.Add(new Label { Text = "I Am Here" });

            //for (int i = 0; i < viewModel.StockOneData.Count; i++)
            //{
            //    int colIndex = 3 * i;
            //    Debug.WriteLine(i);
            //    Debug.WriteLine(grid.Children.ToString());

                
            //    grid.Children.Add(
                    
            //        new BoxView
            //        {
            //            Color = Color.Aqua,

            //            HeightRequest = (double)viewModel.StockOneData[i].Price / 2,

            //            VerticalOptions = LayoutOptions.End,
                        
            //        }, 
            //        colIndex, 0);

            //    grid.Children.Add(
            //        new BoxView
            //        {
            //            Color = Color.Red,

            //            HeightRequest = (double)viewModel.StockTwoData[i].Price / 2,

            //            VerticalOptions = LayoutOptions.End
            //        }, 
            //        colIndex+1, 0);

            //    grid.Children.Add(
            //        new Label
            //        {
            //            Text = viewModel.StockTwoData[i].DateTime.Month.ToString(),
            //            Rotation = 45,
            //            FontSize = 10,
            //            VerticalTextAlignment = TextAlignment.End
            //        }, 
            //        colIndex+1, 1);


            //}
        }
    }
}