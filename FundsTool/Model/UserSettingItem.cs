using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsTool.Model
{
    public class UserSettingItem
    {
        public ObservableCollection<string> Sources { get; set; }
        public IObservable<string> SelectedSources { get; set; }
        public IObservable<bool> IsSelected { get; set; } 
    }
}
