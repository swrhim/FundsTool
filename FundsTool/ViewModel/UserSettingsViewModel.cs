using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundsTool.Model;
using GalaSoft.MvvmLight;

namespace FundsTool.ViewModel
{
    public class UserSettingsViewModel : ViewModelBase
    {
        public UserSettingsViewModel()
        {

            //let's load the initial files
            //TODO: let's make it read from an xml file

            var sources = new List<string>();

            sources.Add("Amex");
            sources.Add("Chase");
            sources.Add("BofA");

            //dynamically build out the rows



            if (IsInDesignMode)
            {
                
            }
        }

        #region properties

        private ObservableCollection<UserSettingItem> _userSettingItems;
        public ObservableCollection<UserSettingItem> UserSettings {
            get { return _userSettingItems; }
            set
            {
                _userSettingItems = value;
                RaisePropertyChanged("UserSettings");
            } 
        }

        #endregion
    }
}
