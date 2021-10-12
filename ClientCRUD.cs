using System;

namespace MKcrud
{
    public class ClientCRUD : ICrud
    {
        public void Create()
        {
            var flag = false;
            var menu = new MenuConsole();
            var clients = AccessFile.GetFile();
            var newClient = menu.ClientMenu(clients,flag);
            clients.Add(newClient);
            AccessFile.SetFile(clients);
        }

        public void Delete(int id)
        {
            var clients = AccessFile.GetFile();
            var find = clients.Find(x => x.DNI == id);
            if (find == null)
            {
                Console.WriteLine("ID not found");
            }
            else if (clients.Remove(find) == true)
            {
                Console.WriteLine("The was deleted successfully!");
                AccessFile.SetFile(clients);
            }
        }

        public void Get(int id)
        {
            var clients = AccessFile.GetFile();
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
            var clients = AccessFile.GetFile();
            var find = clients.Find(x => x.DNI == id);
            if (find == null)
            {
                Console.WriteLine("Dni not found");
            }
            else
            {
                var menu = new MenuConsole();
               var newClient = menu.ClientMenu(clients,flag);
                find.Name = newClient.Name;
                find.LastName = newClient.LastName;
                find.Phone = newClient.Phone;
                find.Province = newClient.Province;
                find.ZipCode = newClient.ZipCode;
                find.City = newClient.City;
                find.Address = newClient.Address;
                AccessFile.SetFile(clients);

            }
        }
    }
}
