using System;

namespace BattleGame
{
    class Program
    {
        static void Main(string[] args)
        { 
            int option;

            do
            {
                Console.WriteLine(" Bienvenido a Battle Game");
                Console.WriteLine("**************************");

                Console.WriteLine(" Menu");
                Console.WriteLine(" 1.- Jugar \n 2.- Instrucciones \n 3.- Ver estadisticas");
                Console.WriteLine(" 4.- Registrarse\n 5.- Salir \n 6.-Acerca de");

                Console.Write("Escoge una opcion (número): ");
                option = Convert.ToInt16(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Opcion invalida, reintenta.");
                        break;
                }
            } while (option != 5);

        }
    }
}
