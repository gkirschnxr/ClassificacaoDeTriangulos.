using System.Reflection;

namespace ClassificacaoDeTriangulos.ConsoleApp
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
                int ladoX;

                while (true)
                {
                    Console.WriteLine("Informe o valor do lado X: ");

                    bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoX);

                    if (conseguiuConverter)
                        break;
                }

                int ladoY;

                while (true)
                {
                    Console.WriteLine("Informe o valor do lado Y: ");

                    bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoY);

                    if (conseguiuConverter)
                        break;
                }

                int ladoZ;

                while (true)
                {                   
                    Console.WriteLine("Informe o valor do lado Z: ");

                    bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoZ);

                    if (conseguiuConverter)
                        break;
                }

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Valores informados:");
                Console.WriteLine("Lado X: " + ladoX);
                Console.WriteLine("Lado Y: " + ladoY);
                Console.WriteLine("Lado Z: " + ladoZ);
                Console.WriteLine("-------------------------------------");

                //verificar a validade do triangulo
                bool medidasTriangulosValidas = 
                    ladoX + ladoY > ladoZ &&
                    ladoX + ladoZ > ladoY &&
                    ladoY + ladoZ > ladoX;

                if (medidasTriangulosValidas == true)
                {
                    // Eqüilátero: Todos os lados iguais;
                    // Isósceles: Dois lados iguais;
                    // Escaleno: Todos os lados diferentes.

                    string tipoTriangulo = "Não classificado";

                    if (ladoX == ladoY && ladoY == ladoZ)
                        tipoTriangulo = "Eqüilátero";

                    else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
                        tipoTriangulo = "Escaleno";

                    else
                        tipoTriangulo = "Isósceles";

                    Console.WriteLine($"O triangulo é {tipoTriangulo}.");
                }
                else
                    Console.WriteLine("Os valores informados não formam um triangulo válido. Tente novamente.");





                Console.WriteLine("_______________________________________");
                Console.Write("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
