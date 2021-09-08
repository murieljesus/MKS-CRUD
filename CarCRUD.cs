using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace MKcrud
{
    public class CarCRUD
    {

        public void Create(Car car)
        {
            var path = @"c:\Users\jesus\source\repos\MKcrud\MKcrud\Jfile.json";
            
            string Mjson = File.ReadAllText(path);
            List<Car> cars = JsonSerializer.Deserialize<List<Car>>(Mjson);

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

             cars.Add(car);

             var json = JsonSerializer.Serialize(cars);
             File.WriteAllText(path, json);
        }
        //
        //C7ar cart = JsonSerializer.Deserialize<Car>(mijson);

        public void Get(int id)
         {
            var path = @"c:\Users\jesus\source\repos\MKcrud\MKcrud\Jfile.json";
            string Mjson = File.ReadAllText(path);
            List<Car> cars = JsonSerializer.Deserialize<List<Car>>(Mjson);

            var find = cars.Find(x => x.Id == id);
            if (find == null)
            {
                Console.WriteLine("ID not found");
            }
            else
            {
                Console.WriteLine("The car exist on the list");
                
            }

        }
         public Car Update(int id)
         {
            var path = @"c:\Users\jesus\source\repos\MKcrud\MKcrud\Jfile.json";
            string Mjson = File.ReadAllText(path);
            List<Car> cars = JsonSerializer.Deserialize<List<Car>>(Mjson);
            var find = cars.Find(x => x.Id == id);
            if (find == null)
            {
                Console.WriteLine("ID not found");
            }
            else
            {
                Console.WriteLine("Insert MODEL:");
                find.Model = Console.ReadLine();

                Console.WriteLine("Insert BRAND:");
                find.Brand = Console.ReadLine();

                Console.WriteLine("Insert TRANSMISSION:");
                find.Trasmission = Console.ReadLine();

                Console.WriteLine("Insert COLOR:");
                find.Color = Console.ReadLine();

                Console.WriteLine("Insert DOORS:");
                find.NumbersDoor = Convert.ToInt32(Console.ReadLine());

                var json = JsonSerializer.Serialize(cars);
                File.WriteAllText(path, json);

            }



            return find;
         }
        public void Delete(int id)
        {

        }


    }
}