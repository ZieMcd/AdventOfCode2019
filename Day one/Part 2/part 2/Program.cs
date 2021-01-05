using System;

namespace part_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double fuelTot = 0;
          
            String[] masses = System.IO.File.ReadAllLines(@"C:\Users\Admin\Code projects\C#\Advent of code\Day one\mass.txt");  

            double fuelExtraTot = 0;
            double fuelExtraCurrent = 0;


            foreach (string mass in masses)
            {
                double massD = Convert.ToDouble(mass);

                fuelTot = fuelTot + (Math.Floor(massD / 3) - 2);
                fuelExtraCurrent = (Math.Floor(massD / 3) - 2);

                while (fuelExtraCurrent >= 0)
                {
                    fuelExtraTot = fuelExtraTot + fuelExtraCurrent;
                    fuelExtraCurrent = Math.Floor(fuelExtraCurrent / 3) - 2;
                }
            }
            Console.WriteLine("Only fuel total: "+fuelTot);
            Console.WriteLine("Extra fuel total: "+ fuelExtraTot);
          

        }
    }
}
