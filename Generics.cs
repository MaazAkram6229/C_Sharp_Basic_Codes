using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Gen<String> Chai = new Gen<string>();
            Chai.Cup = "Maaz";

            Gen<int> pani = new Gen<int>();
            pani.Cup = 23;

            Console.WriteLine("CHAI IS " + Chai.Cup);

            Console.WriteLine("PANI IS " + pani.Cup);
        }
    }
    public class Gen<T> 
    {
        private T cup;
        public T Cup
        {
            get { return cup; }
            set { cup = value; }
        }

    }
}
