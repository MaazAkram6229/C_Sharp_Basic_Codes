
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anser is {0}", isPalindrom(inp));
        }
        static bool isPalindrom(int num)
        {
            string a = Convert.ToString(num);
            int len = a.Length;
            int i = 0;
            for (i = 0; i < len - 1; i++)
            {
                if (a[i] == a[len - i - 1])
                {
                }
                else
                {
                    break;
                }

            }
            if (i == len - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

