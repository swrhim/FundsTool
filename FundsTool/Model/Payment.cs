using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsTool
{
    public class Payment
    {
        public string Source { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Type { get; set; }
    }
}
