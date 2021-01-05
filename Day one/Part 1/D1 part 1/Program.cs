using System;

namespace D1_part_1
{
    class Program
    {
        static void Main(string[] args)
        {

            double fuel = 0;
            String[] masses = System.IO.File.ReadAllLines(@"C:\Users\Admin\Code projects\C#\Advent of code\Day one\mass.txt");

            foreach (string mass in masses)
            {
                fuel = fuel +(Math.Floor(Convert.ToDouble(mass)/3)-2);
            }
            Console.WriteLine(fuel);
        }
    }
}
