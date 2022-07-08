using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;
            Console.WriteLine("Enter the input");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Returns : {0}", func(input));
        }
        static int func(double inp)
        {
            int ans = (int)(100 * (inp - ((double)((int)Math.Truncate(inp)))));
            return ans;
        }
        static int func2(double inp)
        {
            double ans = (inp - Math.Truncate(inp));
            return Convert.ToInt32(ans);
        }
    }
}