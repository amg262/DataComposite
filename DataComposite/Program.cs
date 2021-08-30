using System;

namespace DataComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.Write("1. {0:MMMM dd, yyyy}", today);
        }
    }
}