using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClient
{
    class Program
    {
        static void Main(string[] args)
        {

            WCFDemoService.DemoServiceClient proxy = new WCFDemoService.DemoServiceClient();
            string input = "";

            while (!input.Equals("end"))
            {

                input = Console.ReadLine();
                Console.WriteLine(proxy.getMessage(input));
            }
        }
    }
}
