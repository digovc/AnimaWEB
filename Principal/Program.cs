using System;

namespace AnimeWeb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AppAnimeWeb.i.inicializarServidor();

            Console.WriteLine("Servidor inicializado.");
            Console.WriteLine("______________________");
            Console.WriteLine("Digite qualquer tecla para fechar...");
            Console.ReadKey();

            AppAnimeWeb.i.pararServidor();
        }
    }
}