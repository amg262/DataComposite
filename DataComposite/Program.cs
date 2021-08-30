using System;

namespace DataComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This is the first way of doing it */
            // DateTime today = DateTime.Now;
            // Console.WriteLine("1. {0:MMMM dd, yyyy}", today);
            // Console.WriteLine("2. {0:yyyy.MM.dd}", today);
            // Console.WriteLine("3. Day {0:dd} of {0:MMMM}, {0:yyyy}", today);
            // Console.WriteLine("5. Year: {0:yyyy}, Month: {0:MM}, Day: {0:dd}", today);
            // Console.WriteLine("1. {0:MMMM dd, yyyy}", today);
            // Console.WriteLine("1. {0:MMMM dd, yyyy}", today);
            // Console.WriteLine("1. {0:MMMM dd, yyyy}", today);
            
            DateTime today = DateTime.Now;
            Console.WriteLine($"1.  {today:MMMM today.dd}, {today:yyyy}");
            Console.WriteLine($"2.  {today:yyyy.MM.dd}");
            Console.WriteLine($"3.  Day {today:dd} of {today:MMMM}, {today:yyyy}");
            Console.WriteLine($"4.  Year: {today:yyyy}, Month: {today:MM}, Day: {today:dd}");
            Console.WriteLine($"5.  {today:dddd}");
            Console.WriteLine($"6.  {today:t}");
            Console.WriteLine($"7.  h:{today:hh}. m:{today:mm}, s:{today:ss}");
            Console.WriteLine($"8.  {today:yyyy.MM.dd.hh.mm.ss}");
            
        }
    }
}