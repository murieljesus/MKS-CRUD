using System;
using System.Collections.Generic;

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

            Console.WriteLine("insert DOORS:");
            car.NumbersDoor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\npress any button to continue");
            Console.ReadKey();
            Console.WriteLine("the Car updates successfully!");
            return car;
        }

        public Client ClientMenu(List<Client> clients, bool flag)
        {
            var client = new Client();
            if (flag == false)
            {
                Console.WriteLine("insert DNI number:");
                var checkId = Convert.ToInt32(Console.ReadLine());
                var find = clients.Find(x => x.DNI == checkId);
                if (checkId == find.DNI)
                {
                    Console.WriteLine("The dni already exits");
                }
                else
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
                    Console.WriteLine("press any button to continue");
                    Console.ReadKey();
                    Console.WriteLine("The Client updates successfully!");
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
                Console.WriteLine("press any button to continue");
                Console.ReadKey();
                Console.WriteLine("The Client updates successfully!");

            }
            Console.WriteLine("press any button to continue");
            return client;
        }
    }
}
