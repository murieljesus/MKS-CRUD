using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Text.Json;

namespace MKcrud
{
    class AccessFile
    {
        public static List<Client> GetFile()
        {
            var file = ConfigurationManager.AppSettings["Customerjson"];
            var Mjson = File.ReadAllText(file);
            var clients = JsonSerializer.Deserialize<List<Client>>(Mjson);
            return clients;
        }
        public static void SetFile(List<Client>clients)
        {
            var file = ConfigurationManager.AppSettings["Customerjson"];
            var json = JsonSerializer.Serialize(clients);
            File.WriteAllText(file, json);
        }
        public static List<Car> GetCars()
        {
            var file = ConfigurationManager.AppSettings["Carjson"];
            var Mjson = File.ReadAllText(file);
            var cars = JsonSerializer.Deserialize<List<Car>>(Mjson);
            return cars;
        }
        public static void SetCars(List<Car> cars)
        {
            var file = ConfigurationManager.AppSettings["Carjson"];
            var json = JsonSerializer.Serialize(cars);
            File.WriteAllText(file, json);
        }
    }
}
