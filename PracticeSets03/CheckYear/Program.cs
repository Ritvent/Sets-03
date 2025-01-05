using System;
namespace CheckYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check year if it's a leap year");
            Console.Write("Enter year: ");

            int year = int.Parse(Console.ReadLine());

            if (CheckLeapYear(year))
            {
                Console.WriteLine($"The year {year} is a leap year. ");
            }
            else
            {
                Console.WriteLine($"The year {year} is not a leapy year. ");
            }
        }
        static bool CheckLeapYear(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0 || year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}