using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace MKcrud
{
    class RentCRUD : ICrud
    {
        string file = ConfigurationManager.AppSettings["RentCar"];

        public void Create()
        {
            var rent = AccessFile<RentCar>.GetFile(file);
            var id = rent.Count;
            var menu = new MenuConsole();
            var newRent = menu.rentCar(id);
            rent.Add(newRent);
            AccessFile<RentCar>.SetFile(rent, file);

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
