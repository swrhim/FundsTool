using FundsTool.SampleData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsTool.Utilities
{
    internal class AmexCSVParser : ICSVParser
    {
        /// <summary>
        /// Parse the csv file
        /// </summary>
        /// <param name="fileName"></param>
        public IEnumerable<Payment> ParseFile(string fileName)
        {
            try
            {
                List<Payment> payments = new List<Payment>();
                using (var reader = new StreamReader(File.OpenRead(fileName)))
                {
                    while(!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        var payment = new Payment();

                        var amount = 0.0;

                        //for now we assume a standard format
                        var date = Convert.ToDateTime(values[0]);
                        payment.TransactionDate = date;
                        var amountString = values[3];
                        double.TryParse(amountString, out amount);
                        payment.Amount = amount;
                        payment.Description = values[2];
                        payments.Add(payment);
                    }
                }

                return payments;
            }
            catch (Exception ex)
            { }
            
            return null;
        }
    }
}
