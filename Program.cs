using System;

namespace MKcrud
{
    class Program
    {
        static void Main(string[] args)
        {
            //display console menu
            Console.WriteLine("Choose your options: \n 1- Add \n 2- Search \n 3- Update  \n 4- Delete \n 5- Rent a Car \n 6-Exit");
            var option = Convert.ToInt32(Console.ReadLine());

            //define CarCRUD type
            var crud = new CarCRUD();
            var clientCrud = new ClientCRUD();
            var rent = new RentCRUD();

            //options menu case
            switch (option)
            {
                case 1:
                    Console.WriteLine("Choose your options: \n 1- Add new Car \n 2- Add new Client \n 3- Rent a Car \n");
                    var option1 = Convert.ToInt32(Console.ReadLine());
                    switch (option1)
                    {
                        case 1:
                            crud.Create();
                            break;
                        case 2:
                            clientCrud.Create();
                            break;
                        case 3:
                            rent.Create();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Choose your options: \n 1- Search Car \n 2- Search Client \n 3- Search Rent \n");
                    var option2 = Convert.ToInt32(Console.ReadLine());
                    switch (option2)
                    {
                        case 1:
                            Console.WriteLine("Insert the ID number:");
                            var id = Convert.ToInt32(Console.ReadLine());
                            crud.Get(id);
                            break;
                        case 2:
                            Console.WriteLine("Insert Dni number:");
                            var dni = Convert.ToInt32(Console.ReadLine());
                            clientCrud.Get(dni);
                            break;
                        case 3:
                            Console.WriteLine("Insert ID number:");
                            var idRent = Convert.ToInt32(Console.ReadLine());
                            rent.Get(idRent);
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Choose your options: \n 1- Update Car \n 2- Update Client \n 3- Update Rent \n");
                    var option3 = Convert.ToInt32(Console.ReadLine());
                    switch (option3)
                    {
                        case 1:
                            Console.WriteLine("Insert the ID for update the Car:");
                            var update = Convert.ToInt32(Console.ReadLine());
                            crud.Update(update);
                            break;
                        case 2:
                            Console.WriteLine("Insert the DNI for update Client:");
                            var updateC = Convert.ToInt32(Console.ReadLine());
                            clientCrud.Update(updateC);
                            break;
                        case 3:
                            Console.WriteLine("Insert the ID for update Rent:");
                            var updateRent = Convert.ToInt32(Console.ReadLine());
                            rent.Update(updateRent);
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Choose your options: \n 1- Delete Car \n 2- Delete Client \n 3- Delete Rent \n");
                    var option4 = Convert.ToInt32(Console.ReadLine());
                    switch (option4)
                    {
                        case 1:
                            Console.WriteLine("Insert the ID for delete:");
                            var del = Convert.ToInt32(Console.ReadLine());
                            crud.Delete(del);
                            break;
                        case 2:
                            Console.WriteLine("Insert the DNI for delete Client:");
                            var delC = Convert.ToInt32(Console.ReadLine());
                            clientCrud.Delete(delC);
                            break;
                        case 3:
                            Console.WriteLine("Insert the ID for delete Rent:");
                            var delRent = Convert.ToInt32(Console.ReadLine());
                            rent.Delete(delRent);
                            break;
                    }
                    break;
            }
        }
    }
}