using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleServiceConsumer22.ServiceReference222;

namespace ConsoleServiceConsumer22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1HelloSoapClient client = new WebService1HelloSoapClient();
            Console.WriteLine(client.HelloWorld());
           // Console.WriteLine(client.SayHelloToMe("sony"));
        }
    }
}
