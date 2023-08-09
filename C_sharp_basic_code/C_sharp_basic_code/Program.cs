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
            int age = 20;

            if (age < 18)
            {
                Console.WriteLine("The sindicate will not tolerate this behaviour, report to your supervisor immediately!");
            } 
            else Console.WriteLine("You are in the appropiate age range, please proceed!");

            switch (age)
            {
                default:
                    Console.WriteLine("Register yourself before enrolling!");
                    break;
                case 17:
                    Console.WriteLine("Soldier you are close to graduating, pacience");
                        break;
                case 30:
                    Console.WriteLine("You will be asigned your task for today at station 20 soldier");
                        break;
            }
            
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
