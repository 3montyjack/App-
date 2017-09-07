namespace AppTestActual.Models
{
    public abstract class BaseViewableObject : BaseDataObject
    {
        private string _displayTitle = string.Empty;

        public string Title
        {
            get => _displayTitle;
            set => SetProperty(ref _displayTitle, value);
        }
    }
}