using GalaSoft.MvvmLight;

namespace FundsTool.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel()
        {
            if (IsInDesignMode)
                _header = "Test";
            else
            {
                _header = "Select";
            }
        }

        #region properties

        private string _header;
        public string Header
        {
            get
            {
                return _header;
            }
            set
            {
                _header = value;
                RaisePropertyChanged("Header");
            }
        }

        #endregion properties
    }
}
