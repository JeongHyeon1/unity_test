using System;
namespace jh
{
    class Program
    {
        public delegate void DelegatePrintKey(char key);
        public static void PrintKey(char key)
        {
            Console.WriteLine(key);
        }
        static void Main(string[] args)
        {
            DelegatePrintKey d_printkey = new DelegatePrintKey(PrintKey);

            char k = Console.ReadKey().KeyChar;
            d_printkey(k);
        }
    }
}