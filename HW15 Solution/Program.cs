using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLHandler handler1 = new XMLHandler();
            TXTHandler handler2 = new TXTHandler();
            DOCHandler handler3 = new DOCHandler();
            handler1.Create();
            handler1.Open();
            handler1.Change();
            handler1.Save();
            Console.WriteLine("\n");
            handler2.Create();
            handler2.Open();
            handler2.Change();
            handler2.Save();
            Console.WriteLine("\n");
            handler3.Create();
            handler3.Open();
            handler3.Change();
            handler3.Save();
            Console.WriteLine("\n");
        }
    }
}
