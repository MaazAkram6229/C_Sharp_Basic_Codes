
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numnber");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter power");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PowerValue(a, b));
        }

        static int PowerValue(int num, int power)
        {

            if (power != 0)
            {
                return num * PowerValue(num, power - 1);
            }
            return 1;


        }
    }


}