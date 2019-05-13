using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST.MonitorWCF;
namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client service1Client = new Service1Client();
            service1Client.log("lol");
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("finished");
            Console.ReadLine();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
