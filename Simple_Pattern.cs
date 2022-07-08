
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

            for (int i = 1; i < 6; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            for (int i = 1; i < 10; i = i + 2)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            for (int i = 1; i < 15; i = i + 3)
            {
                Console.Write("{0} ", i);
            }
            Console.Read();
        }

    }
}