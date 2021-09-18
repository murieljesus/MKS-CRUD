using System;


namespace MKcrud
{
    public class CarCRUD : ICrud
    {
        public void Create()
        {
            var menu = new MenuConsole();
            var cars = AccessFile.GetCars();
            var id = cars.Count;
            var newCar = menu.CarMenu(id);
            cars.Add(newCar);
            AccessFile.SetCars(cars);
        }
        public void Get(int id)
        {
            var cars = AccessFile.GetCars();
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
            var cars = AccessFile.GetCars();
            var find = cars.Find(x => x.Id == id);
            if (find == null)
            {
                Console.WriteLine("ID not found");
            }
            else
            {
                var menu = new MenuConsole();
                var newCar = menu.CarMenu(find.Id);
                find.Brand = newCar.Brand;
                find.Model = newCar.Model;
                find.Trasmission = newCar.Trasmission;
                find.Color = newCar.Color;
                find.NumbersDoor = newCar.NumbersDoor;
                AccessFile.SetCars(cars);

            }
        }
        public void Delete(int id)
        {
            var cars = AccessFile.GetCars();
            var find = cars.Find(x => x.Id == id);
            if (find == null)
            {
                Console.WriteLine("ID not found");
            }
            else if (cars.Remove(find) == true)
            {
                Console.WriteLine("The was deleted successfully!");
                AccessFile.SetCars(cars);
            }
        }
    }
}