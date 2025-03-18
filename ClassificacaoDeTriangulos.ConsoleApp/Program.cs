﻿namespace ClassificacaoDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //exibir o menu
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Classificador de Triangulos");
                Console.WriteLine("-------------------------------------");

                //receber a entrada (input) dos dados
                Console.WriteLine("Informe o valor do lado X: ");
                int ladoX = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o valor do lado Y: ");
                int ladoY = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o valor do lado Z: ");
                int ladoZ = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Valores informados:");
                Console.WriteLine("Lado X: " + ladoX);
                Console.WriteLine("Lado Y: " + ladoY);
                Console.WriteLine("Lado Z: " + ladoZ);
                Console.WriteLine("-------------------------------------");

                Console.Write("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
