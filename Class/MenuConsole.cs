using MKcrud.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using static MKcrud.Enum.NumberDoors;

namespace MKcrud
{
    class MenuConsole
    {
        public Car CarMenu(int id)
        {
            var car = new Car
            {
                Id = id
            };

            Console.WriteLine("insert MODEL:");
            car.Model = Console.ReadLine();

            Console.WriteLine("insert BRAND:");
            car.Brand = Console.ReadLine();

            Console.WriteLine("insert TRANSMISSION:");
            car.Trasmission = Console.ReadLine();

            Console.WriteLine("insert COLOR:");
            car.Color = Console.ReadLine();

            Console.WriteLine("insert DOORS (0 four doors or 1 three doors):");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                car.numberDoor = Convert.ToString(NumberDoor.four_Doors);
            }
            else
            {
                car.numberDoor = Convert.ToString(NumberDoor.three_Doors);

            }

            Console.WriteLine("\npress any button to continue");
            Console.ReadKey();
            Console.WriteLine("the Car updates successfully!");
            return car;
        }

        public Client ClientMenu(List<Client> clients, Boolean flag)
        {

            var client = new Client();
            if (flag == false)
            {

                Console.WriteLine("insert DNI number:");
                var checkId = Convert.ToInt32(Console.ReadLine());
      
                if (clients.Find(x => x.DNI == checkId) == null)
                {
                    client.DNI = checkId;
                    Console.WriteLine("insert Name:");
                    client.Name = Console.ReadLine();

                    Console.WriteLine("insert Last Name:");
                    client.LastName = Console.ReadLine();

                    Console.WriteLine("insert Address:");
                    client.Address = Console.ReadLine();

                    Console.WriteLine("insert City:");
                    client.City = Console.ReadLine();

                    Console.WriteLine("insert Province:");
                    client.Province = Console.ReadLine();

                    Console.WriteLine("insert Zip Code:");
                    client.ZipCode = Console.ReadLine();

                    Console.WriteLine("insert Phone Number:");
                    client.Phone = Convert.ToInt32(Console.ReadLine());

                    client.Date = DateTime.Now.ToString("dd-MM-yyyy");
                    Console.WriteLine("press any button to continue");
                    Console.ReadKey();
                    Console.WriteLine("The Client updates successfully!");
                }
                else
                {
                    Console.WriteLine("The dni already exits");
                }
            }
            else
            {
                Console.WriteLine("insert Name:");
                client.Name = Console.ReadLine();

                Console.WriteLine("insert Last Name:");
                client.LastName = Console.ReadLine();

                Console.WriteLine("insert Address:");
                client.Address = Console.ReadLine();

                Console.WriteLine("insert City:");
                client.City = Console.ReadLine();

                Console.WriteLine("insert Province:");
                client.Province = Console.ReadLine();

                Console.WriteLine("insert Zip Code:");
                client.ZipCode = Console.ReadLine();

                Console.WriteLine("insert Phone Number:");
                client.Phone = Convert.ToInt32(Console.ReadLine());

                client.Date = DateTime.Now.ToString("dd-MM-yyyy");

                Console.WriteLine("press any button to continue");
                Console.ReadKey();
                Console.WriteLine("The Client updates successfully!");

            }
            Console.WriteLine("press any button to continue");
            return client;
        }
        //funciona pero hay que modificarlo para que sea modular
        public RentCar rentCar(int id)
        {
            var rent = new RentCar
            {
                Id = id
            };
            string file = ConfigurationManager.AppSettings["Carjson"];

            Console.WriteLine("insert the car Id:");
            var carId = Convert.ToInt32(Console.ReadLine());
            var cars = AccessFile<Car>.GetFile(file);

            var find = cars.Find(x => x.Id == carId);
            rent.RentCars = find;
            return rent ;
        }
    }
}
