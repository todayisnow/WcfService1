using ConsoleApplication1.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DuplexChannelFactory<IService1> c = new DuplexChannelFactory<IService1>(new mycall(), "WSDualHttpBinding_IService1");
            var x = c.CreateChannel();
            x.GetData(55);
            Console.ReadLine();

           
        }
    }

    public class mycall : ServiceReference1.IService1Callback
    {
        public void done(int x)
        {
            Console.WriteLine("client");
        }
    }
}
