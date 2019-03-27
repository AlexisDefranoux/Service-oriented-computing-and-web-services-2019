using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyConverter.Currency;
namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            ConverterSoap converter = new ConverterSoapClient();
            var conversion = converter.GetCurrencyRates(DateTime.Now);
            Console.WriteLine(conversion);            
        }
    }
}
