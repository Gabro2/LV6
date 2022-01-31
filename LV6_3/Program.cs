using System;
using System.Linq;
using System.Collections.Generic;
namespace LV6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Car> cars = Networking.GetUsedCars();
            Tester.GetManufacturers(cars);
            Tester.GetManufacturerWithMaxKm(cars);
            Tester.GetAverageAgeOfDacias(cars);
            Tester.TimeSpanOfManufacturedCars(cars);
        }
    }
}
