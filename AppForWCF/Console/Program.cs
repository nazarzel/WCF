using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ConsoleApp
{
    [ServiceContract]
    public interface IMyMath
    {
        [OperationContract]
        int Add(int a, string c, int b);
    }

    public class MyMath : IMyMath
    {

        public int Add(int a, string c, int b)
        {
            switch (c)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    {

                        return a * b;
                    }
                case "/":
                    {
                        if (a == 0 || b == 0)
                        {
                            return -2;
                        }
                        return a / b;
                    }
                default:
                {
                    return 0;
                }
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(MyMath));
            sh.AddServiceEndpoint(
                typeof(IMyMath),
                new WSHttpBinding(),
                "http://localhost/MyMath/Ep1"
                );
            sh.Open();
            Console.WriteLine("press something\n");
            Console.ReadLine();
            sh.Close();
        }
    }
}
