using MKcrud.Class;
using System;
using System.Configuration;

namespace MKcrud
{
    public class CarCRUD : ICrud
    {
        string file = ConfigurationManager.AppSettings["Carjson"];
        MenuConsole menu = new MenuConsole();

        public void Create()
        {
            var cars = AccessFile<Car>.GetFile(file);
            var id = cars.Count;
            var newCar = menu.CarMenu(id);
            cars.Add(newCar);
            AccessFile<Car>.SetFile(cars, file);

        }
        public void Get(int id)
        {

            var cars = AccessFile<Car>.GetFile(file);
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
        public void Update(int id)
        {
            var cars = AccessFile<Car>.GetFile(file);
            var find = cars.Find(x => x.Id == id);
            if (find == null)
            {
                Console.WriteLine("ID not found");
            }
            else
            {
                var newCar = menu.CarMenu(find.Id);
                find.Brand = newCar.Brand;
                find.Model = newCar.Model;
                find.Trasmission = newCar.Trasmission;
                find.Color = newCar.Color;
                AccessFile<Car>.SetFile(cars, file);

            }
        }
        public void Delete(int id)
        {
            var cars = AccessFile<Car>.GetFile(file);
            var find = cars.Find(x => x.Id == id);
            if (find == null)
            {
                Console.WriteLine("ID not found");
            }
            else if (cars.Remove(find) == true)
            {
                Console.WriteLine("The was deleted successfully!");
                AccessFile<Car>.SetFile(cars, file);
            }
        }
    }
}