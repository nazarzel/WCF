using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ProxyClass_wcf.ServiceReference1;


namespace ProxyClass_wcf
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDiskClient proxy = new MyDiskClient();

            string total = proxy.TotalSpace("C");
            string free = proxy.FreeSpace("D");

            Console.WriteLine("TotalSpace =  {0}", total);
            Console.WriteLine("FreeSpace =  {0}", free);

            Console.WriteLine("Press ENTER for ending...");
            Console.ReadLine();

        }
    }
}
