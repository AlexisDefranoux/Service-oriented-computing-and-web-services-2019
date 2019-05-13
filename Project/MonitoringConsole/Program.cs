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
            string[] logging = monitor.getLogs();
            for (int i = 0; i < logging.Length; i++)
            {
                Console.WriteLine(logging[i]);
            }
            Console.ReadLine();
        }
    }
}
