using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_basic_code
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 59;
            Console.WriteLine("Hello world! "+a);

            TestFunction();
            bool ok = ValueLessThan100(a);
            Console.WriteLine(ok);
            
            Console.ReadKey();
        }

        static void TestFunction()
        {
            Console.WriteLine("This was a secret and you faild to protect it!");
        }
        static bool ValueLessThan100(int number)
        {
            return number < 100;
        }
    }
}
