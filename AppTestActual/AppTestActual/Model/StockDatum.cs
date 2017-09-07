using System;


namespace AppTestActual.Models
{
    /// <summary>
    /// Represents the price of the stock at a specific time
    /// </summary>
    public class StockDatum : BaseDataObject
    {
        private DateTime dateTime = DateTime.Now;
        private decimal price;
        private string parentId = string.Empty;

        /// <summary>
        /// The timestamp at the instant of this price
        /// </summary>
        public DateTime DateTime
        {
            get => dateTime;
            set => SetProperty(ref dateTime, value);
        }

        /// <summary>
        /// The price at the time of the property 'DateTime'
        /// </summary>
        public decimal Price
        {
            get => price;
            set => SetProperty(ref price, value);
        }

        /// <summary>
        /// Id of the stock
        /// </summary>
        public string ParentId
        {
            get => parentId;
            set => SetProperty(ref parentId, value);
        }
    }
}
