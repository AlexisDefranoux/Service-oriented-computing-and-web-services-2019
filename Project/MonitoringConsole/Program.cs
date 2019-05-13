using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonitoringConsole.MonitorWCF;

namespace MonitoringConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client monitor = new Service1Client();
            LogItem[] logging = monitor.GetLogs();
            for (int i = 0; i < logging.Length; i++)
            {
                Console.WriteLine(logging[i].date.ToString() + " : " + logging[i].mess + " and the method duration is : " + logging[i].time.ToString());
            }
            Console.ReadLine();
        }
    }
}
