using System;

namespace DataComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("1. {0:MMMM dd, yyyy}", today);
            Console.WriteLine("2. {0:yyyy.mm.dd}", today);
            Console.Write("1. {0:MMMM dd, yyyy}", today);
            Console.Write("1. {0:MMMM dd, yyyy}", today);
            Console.Write("1. {0:MMMM dd, yyyy}", today);
            Console.Write("1. {0:MMMM dd, yyyy}", today);
            Console.Write("1. {0:MMMM dd, yyyy}", today);
            Console.Write("1. {0:MMMM dd, yyyy}", today);
            Console.Write("1. {0:MMMM dd, yyyy}", today);
        }
    }
}