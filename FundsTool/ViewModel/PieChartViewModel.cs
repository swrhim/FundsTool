using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace FundsTool.ViewModel
{
    public class PieChartViewModel : ViewModelBase
    {
        public PieChartViewModel()
        {
            _items = new ObservableCollection<Payment>()
            {
                new Payment { Description="TEST", Amount=100},
                new Payment { Description="TEST1", Amount=500},
                new Payment { Description="TEST2", Amount=450},
                new Payment { Description="TEST3", Amount=130},
                new Payment { Description="TEST4", Amount=200},
            };

            _independent = "Description";
            _dependent = "Amount";

            if (IsInDesignMode)
            {
            }
            else
            {

            }
        }

        private ObservableCollection<Payment> _items;
        public ObservableCollection<Payment> Items
        {
            get
            {
                return _items;
            }
        }

        private string _independent;
        public string Independent
        {
            get
            {
                return _independent;
            }
        }

        private string _dependent;
        public string Dependent
        {
            get
            {
                return _dependent;
            }
        }
    }
}
