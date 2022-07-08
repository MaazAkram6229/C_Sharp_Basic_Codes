using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 ="" ;
            string s2 = "";
            int k = 0;
            Console.WriteLine("Enter frist string");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            s2 = Console.ReadLine();
            Console.WriteLine("Enter k");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isAnagram(s1, s2, k));
            Console.ReadLine();
        }
        static bool isAnagram(string s1, string s2, int k)
        {
            int counter = 0;

            if (s1.Length != s2.Length)
            {
                return false;
            }
            else
            {
                int i;
                for ( i = 0; i <= s1.Length-1; i++)
                {
                    if (s1[i] == s2[i])
                    {
                        counter++;
                    }
                }
                if (k <= s1.Length - counter)
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
}
