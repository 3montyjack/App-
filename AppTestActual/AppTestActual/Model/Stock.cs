using System;

namespace AppTestActual.Models
{
    public class Stock : BaseViewableObject
    {
        private string exchangeSourceName = string.Empty;
        private string exchangeStockName = string.Empty;
        private string symbol = string.Empty;
        private string name = string.Empty;
        private decimal purchasePrice;
        private decimal currentPrice;
        private DateTime purchaseTime = DateTime.Now;

        public string Symbol
        {
            get => symbol;
            set => SetProperty(ref symbol, value);
        }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string ExchangeStockName
        {
            get => exchangeStockName;
            set => SetProperty(ref exchangeStockName, value);
        }

        public string ExchangeSourceName
        {
            get => exchangeSourceName;
            set => SetProperty(ref exchangeSourceName, value);
        }

        public decimal PurchasePrice
        {
            get => purchasePrice;
            set => SetProperty(ref purchasePrice, value);
        }

        public decimal CurrentPrice
        {
            get => currentPrice;
            set => SetProperty(ref currentPrice, value);
        }

        public DateTime PurchaseTime
        {
            get => purchaseTime;
            set => SetProperty(ref purchaseTime, value);
        }

        public decimal Profit => CurrentPrice - PurchasePrice;

        public decimal PercentageGained
        {
            get
            {
                try
                {
                    return ((Profit / PurchasePrice) * 100);
                }
                catch (DivideByZeroException) { return 0; }
            }
        }
    }
}
