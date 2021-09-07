using System;

namespace MKcrud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your options: \n 1- add car \n 2- search car \n 3- update list  \n 4-delete car \n 5- Exit");
            var option = Convert.ToInt32(Console.ReadLine());
            var newcar = new Car();
            var crud = new CarCRUD();

            Console.WriteLine("\n");

            switch (option)
            {
                case 1:
                    crud.Create(newcar);
                    break;
                case 2:
                    Console.WriteLine("Insert the ID number:");
                    var id= Convert.ToInt32(Console.ReadLine());
                    crud.Get(id);

                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }
    }
}       