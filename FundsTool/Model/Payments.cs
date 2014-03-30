using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsTool.Model
{
    public class PaymentsDao
    {
        private static PaymentsDao _instance = new PaymentsDao();

        public PaymentsDao()
        {
            this.Payments = new ObservableCollection<Payment>();
        }

        public static PaymentsDao Instance
        {
            get { return _instance ?? (_instance = new PaymentsDao()); }
        }

        public ObservableCollection<Payment> Payments { get; set; }
    }
}
