namespace ConsoleApplication5
{
    using System;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            string[] a = new string[10];
            int count = 0;
            Console.WriteLine("Input String");
            string inp = Console.ReadLine();


            int len = inp.Length;
            for (int i = 0; i < len - 1; i++)
            {
                a[count] = a[count] + inp[i];
                for (int j = i; j < len - 1; j++)
                {
                    if (inp[i] != inp[j + 1])
                    {
                        if (j == len - 2)
                        {
                            a[count] = "";
                        }
                        else
                        {
                            a[count] = a[count] + inp[j + 1];
                        }
                    }
                    else if (inp[i] == inp[j + 1])
                    {
                        count++;
                        break;
                    }
                }
            }
            int maxlen = 0;
            int ele = 0;
            for (int k = 0; k < 9; k++)
            {
                if (a[k] != null)
                {

                    ele = k;
                }

            }
            for (int k = 0; k <= ele; k++)
            {
                if (a[k].Length > maxlen)
                {
                    maxlen = a[k].Length;
                }
            }

            for (int k = 0; k <= ele; k++)
            {
                if (a[k].Length == maxlen)
                {
                    Console.WriteLine("str is :{0}", a[k]);
                }
            }
            Console.Read();
        }
    }
}

















