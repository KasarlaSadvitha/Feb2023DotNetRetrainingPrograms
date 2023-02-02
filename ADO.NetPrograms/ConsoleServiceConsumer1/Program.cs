using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleServiceConsumer1.ServiceReference1;
//using ConsoleServiceConsumer1.ServiceReference2;

namespace ConsoleServiceConsumer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1HelloSoapClient client = new WebService1HelloSoapClient();
            Console.WriteLine(client.HelloWorld());
            //SayHelloToMe
           // Console.WriteLine(client.SayHelloToMe());
            Console.ReadKey();
        }
    }
}
