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
                    case 1: // Play
                        play();
                        break;
                    case 2: // Instructions
                        instructions();
                        break;
                    case 3: // Stadistics 
                        stadistics();
                        break;
                    case 4: // Sign up
                        signUp();
                        break;
                    case 5: // Exit Game
                        exit();
                        break;
                    case 6: // About Game
                        aboutGame();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida, reintenta.");
                        break;
                }
            } while (option != 5);
            
        }

        public static void play()
        {

        }

        public static void instructions()
        {

        }

        public static void stadistics()
        {

        }

        public static void signUp()
        {

        }

        public static void exit()
        {
            Console.WriteLine("Gracias por haber visitado el juego! \nEsperamos lo hayas disfrutado!");
            Console.WriteLine("Da enter para salir del juego");
            Console.ReadKey();
        }

        public static void aboutGame()
        {

        }

    }
}
