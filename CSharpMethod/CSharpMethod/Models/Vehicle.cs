using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMethod.Models
{
    class Vehicle
    {
        public string Brand;
        public double FuelConsuption;
        public double Capasity;
        public double CurrentFuel;

        public Vehicle(string brand, int fuelConsuption, int capasity)
        {
            Brand = brand;
            FuelConsuption = fuelConsuption;
            Capasity = capasity;
        }

        public void Run(int currentFuel,double km)
        {
            CurrentFuel = currentFuel;
            double maxKm=currentFuel / FuelConsuption * 100;
            double neededFuel = km / 100 * FuelConsuption;
            if (maxKm < km)
            {
                double additionalFuel = neededFuel - currentFuel;
                if (additionalFuel + CurrentFuel > Capasity)
                {
                    Console.WriteLine("Bir bak bes elemir");
                }
                else
                {
                    Console.WriteLine($"{additionalFuel} litr benzin elave etmelisiniz");
                }
            }
            else
            {
                CurrentFuel = currentFuel - neededFuel;
                Console.WriteLine($"Gede biler. Qalan yanacaq {CurrentFuel}");
            }
        }
    }
}
