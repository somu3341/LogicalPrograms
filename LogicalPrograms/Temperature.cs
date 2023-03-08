using System;
namespace LogicalPrograms
{
    public class Temperature
    {
        public void degree(int cels, int fahr)
        {
            switch (cels)
            {
                case 1:
                    int F = (fahr * 9 / 5) + 32;
                    Console.WriteLine("Celsius to Fahrenheit = " + F + "°F");
                    break;
                case 2:
                    int C = (fahr - 32) * 5 / 9;
                    Console.WriteLine("Fahrenheit to Celsius = " + C + "°C");
                    break;
            }
        }
    }
}