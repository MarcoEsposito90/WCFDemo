using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DemoHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(WCFDemoService.DemoService)))
            {

                host.Open();
                Console.WriteLine("Service open. waiting client requests. Press enter to stop");
                Console.ReadLine();
            }
        }
    }
}
