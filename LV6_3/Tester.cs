using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LV6_3
{
    static class Tester
    {
        public static void GetManufacturers(IEnumerable<Car> cars)
        {
            /*string*/
            var manufacturers = cars.Select(car => car.Make).OrderBy(car => car).ToHashSet();
            Console.WriteLine(string.Join("\n", manufacturers) + Environment.NewLine);
        }
        public static void GetManufacturerWithMaxKm(IEnumerable<Car> cars)
        {
            int max = cars.Select(car => car.Km).Max();
            var manufacturers = cars.Where(car1 => car1.Km == max).Select(car1 => car1.Make);
            Console.WriteLine(string.Join("\n", manufacturers) + Environment.NewLine);
        }
        public static void GetAverageAgeOfDacias(IEnumerable<Car> cars)
        {
            var dacias = cars.Where(car => car.Make == "Dacia").Select(car => car.Year);
            double sum = 0;
            foreach (var dacia in dacias)
            {
                sum += dacia;
            }
            Console.WriteLine(sum / dacias.Count() + Environment.NewLine);
        }
        public static void TimeSpanOfManufacturedCars(IEnumerable<Car> cars)
        {
            var minAge = cars.Select(car => car.Year).Min();
            var maxAge = cars.Select(car => car.Year).Max();
            Console.WriteLine(minAge + " - " + maxAge);
        }
    }
}
