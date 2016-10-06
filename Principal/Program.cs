using System;

namespace AnimaWeb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AppAw.i.inicializarServidor();

            Console.WriteLine("Servidor inicializado.");
            Console.WriteLine("______________________");
            Console.WriteLine("Digite qualquer tecla para fechar...");
            Console.ReadKey();

            AppAw.i.pararServidor();
        }
    }
}