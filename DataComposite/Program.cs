using System;

namespace DataComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("1. {0:MMMM dd, yyyy}", today);
            Console.WriteLine("2. {0:yyyy.MM.dd}", today);
            Console.WriteLine("3. Day {0:dd} of {0:MMMM}, {0:yyyy}", today);
            Console.WriteLine("5. Year: {0:yyyy}, Month: {0:MM}, Day: {0:dd}", today);
            Console.WriteLine("1. {0:MMMM dd, yyyy}", today);
            Console.WriteLine("1. {0:MMMM dd, yyyy}", today);
            Console.WriteLine("1. {0:MMMM dd, yyyy}", today);
        }
    }
}