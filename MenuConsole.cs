using System;
using System.Collections.Generic;
using System.Text;

namespace MKcrud
{
    class MenuConsole
    {
        public Car Menu(Car car)
        {
            Console.WriteLine("insert Id number:");
            car.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insert MODEL:");
            car.Model = Console.ReadLine();

            Console.WriteLine("insert BRAND:");
            car.Brand = Console.ReadLine();

            Console.WriteLine("insert TRANSMISSION:");
            car.Trasmission = Console.ReadLine();

            Console.WriteLine("insert COLOR:");
            car.Color = Console.ReadLine();

            Console.WriteLine("insert DOORS:");
            car.NumbersDoor = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
            Console.WriteLine("the Car updates successfully!");
            return car;
        }
    }
}
