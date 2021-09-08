using System;

namespace MKcrud
{
    class Program
    {
        static void Main(string[] args)
        {
            //display console menu
            Console.WriteLine("Choose your options: \n 1- add car \n 2- search car \n 3- update list  \n 4-delete car \n 5- Exit");
            var option = Convert.ToInt32(Console.ReadLine());

            //define a type Car and a CarCRUD type
            var newcar = new Car();
            var crud = new CarCRUD();

            Console.WriteLine("\n");

            //options menu case
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
                    Console.WriteLine("Insert the ID for update the Car:");
                    var update = Convert.ToInt32(Console.ReadLine());
                    crud.Update(update);
                    break;
                case 4:
                    break;
            }
        }
    }
}       