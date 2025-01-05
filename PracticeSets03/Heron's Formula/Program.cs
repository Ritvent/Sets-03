using System;
namespace FormulaHeron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first side: ");
            double sideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second side: ");
            double sideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third side: ");
            double sideC = int.Parse(Console.ReadLine());


            double area = HeronFormula(sideA, sideB, sideC);
            Console.WriteLine($"The area using Heron's formula equals to {area}");


        }
        static double HeronFormula(double sideA, double sideB, double sideC)
        {
            double s = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

            return area;
        }
    }
}