using System;

namespace CatGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, Bienvenido al programa de creación de gatos!!");

            do
            {
                Cat.CrearGato();
            } while (Continue());
        }

        public static bool Continue()
        {
            Console.WriteLine("¿Desea crear otro gato? [Y / N]\n");
            var answer = Console.ReadKey(true);
            while (answer.Key != ConsoleKey.N && answer.Key != ConsoleKey.Y)
            {
                Console.WriteLine("La tecla presionada no es valida, por favor intente nuevamente.\t [Y / N]\n");
                answer = Console.ReadKey(true);
            }
            if (answer.Key == ConsoleKey.Y)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
