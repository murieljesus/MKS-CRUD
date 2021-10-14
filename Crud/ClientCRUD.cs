using System;
using System.Configuration;

namespace MKcrud
{
    public class ClientCRUD : ICrud
    {
        string file = ConfigurationManager.AppSettings["Customerjson"];

        public void Create()
        {
            var flag = false;
            var clients = AccessFile<Client>.GetFile(file);
            var menu = new MenuConsole();
            var newClient = menu.ClientMenu(clients, flag);
            clients.Add(newClient);
            AccessFile<Client>.SetFile(clients, file);

        }

        public void Delete(int id)
        {
            var clients = AccessFile<Client>.GetFile(file);
            var find = clients.Find(x => x.DNI == id);
            if (find == null)
            {
                Console.WriteLine("ID not found");
            }
            else if (clients.Remove(find) == true)
            {
                Console.WriteLine("The clietn was deleted successfully!");
                AccessFile<Client>.SetFile(clients, file);
            }
        }

        public void Get(int id)
        {
            var clients = AccessFile<Client>.GetFile(file);
            var find = clients.Find(x => x.DNI == id);
            if (find == null)
            {
                Console.WriteLine("ID not found");
            }
            else
            {
                Console.WriteLine("The Client exist on the list");
            }
        }

        public void Update(int id)
        {
            var flag = true;
            var clients = AccessFile<Client>.GetFile(file);
            var find = clients.Find(x => x.DNI == id);
            if (find == null)
            {
                Console.WriteLine("Dni not found");
            }
            else
            {
                var menu = new MenuConsole();
                var newClient = menu.ClientMenu(clients, flag);
                find.Name = newClient.Name;
                find.LastName = newClient.LastName;
                find.Phone = newClient.Phone;
                find.Province = newClient.Province;
                find.ZipCode = newClient.ZipCode;
                find.City = newClient.City;
                find.Address = newClient.Address;
                AccessFile<Client>.SetFile(clients, file);

            }
        }
    }
}
