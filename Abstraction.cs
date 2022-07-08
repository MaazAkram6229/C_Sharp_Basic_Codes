namespace practice
{
    using System;

    internal class Program
    {
        internal abstract class add
        {
            public abstract void Add();

        }

        internal class child1add : add
        {
            public override void Add()
            {
                Console.WriteLine("Child1 Add"); ;
            }
        }

        internal class child2add : add
        {
            public override void Add()
            {
                Console.WriteLine("Child2 Add"); ;
            }
        }

        internal static void Main(string[] args)
        {
            // array of objects 

            add[] myobj=new add[2];

            myobj[0] = new child1add();
            myobj[1] = new child2add();

            myobj[0].Add();
            myobj[1].Add();
        }
    }
}
