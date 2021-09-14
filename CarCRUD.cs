using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MKcrud
{
    public class CarCRUD
    {
        public void Create(Car car)
        {
            //define a var that store the root 
            var path = @"c:\Users\jesus\source\repos\MKcrud\MKcrud\Jfile.json";
            var Mjson = File.ReadAllText(path);

            List<Car> cars = JsonSerializer.Deserialize<List<Car>>(Mjson);

            var menu = new MenuConsole();
            menu.Menu(car);
            cars.Add(car);

            var json = JsonSerializer.Serialize(cars);
            File.WriteAllText(path, json);
        }
        public void Get(int id)
        {
            var path = @"c:\Users\jesus\source\repos\MKcrud\MKcrud\Jfile.json";
            var Mjson = File.ReadAllText(path);
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
            var Mjson = File.ReadAllText(path);
            List<Car> cars = JsonSerializer.Deserialize<List<Car>>(Mjson);
            var find = cars.Find(x => x.Id == id);
            if (find == null)
            {
                Console.WriteLine("ID not found");
            }
            else
            {

                var menu = new MenuConsole();
                menu.Menu(find);

                var json = JsonSerializer.Serialize(cars);
                File.WriteAllText(path, json);
            }
            return find;
        }
        public void Delete(int id)
        {
            var path = @"c:\Users\jesus\source\repos\MKcrud\MKcrud\Jfile.json";
            var Mjson = File.ReadAllText(path);
            List<Car> cars = JsonSerializer.Deserialize<List<Car>>(Mjson);

            var find = cars.Find(x => x.Id == id);
            if (find == null)
            {
                Console.WriteLine("ID not found");
            }
            else if (cars.Remove(find) == true)
            {
                Console.WriteLine("The was deleted successfully!");
                var json = JsonSerializer.Serialize(cars);
                File.WriteAllText(path, json);
            }
        }
    }
}