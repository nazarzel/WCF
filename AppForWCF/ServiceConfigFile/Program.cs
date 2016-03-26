using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServiceConfigFile
{
    [ServiceContract]
    public interface IMyMath
    {
        [OperationContract]
        int Add(int a, int b);
    }
    public class MathService : IMyMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(MathService));
            sh.Open();
            Console.WriteLine("press something\n");
            Console.ReadLine();
            sh.Close();
        }
    }
}
