using System;

namespace RulesEngineDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rules Engine Demo\n\n");

            new BasicDemo().Run();
            //new NestedInputDemo().Run();
        }
    }
}
