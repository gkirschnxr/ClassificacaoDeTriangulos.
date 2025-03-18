namespace ClassificacaoDeTriangulos.ConsoleApp;
internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            //exibir cabecalho
            ExibirCabecalho();

            //ler lados
            int ladoX = LerLados("X");
            int ladoY = LerLados("Y");
            int ladoZ = LerLados("Z");

            //exibir valores
            ExibirValoresInformados(ladoX, ladoY, ladoZ);

            //verificar a validade do triangulo

            bool medidasFormamTrianguloValido =
                ClassificadorDeTriangulos.ValidacaoDeTriangulo(ladoX, ladoY, ladoZ);

            if (medidasFormamTrianguloValido)
            {
                string tipoTriangulo = ClassificadorDeTriangulos.ClassificarTriangulo(ladoX, ladoY, ladoZ);

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


    static void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Classificador de Triangulos");
        Console.WriteLine("-------------------------------------");
    }

    static int LerLados(string nomeLado)
    {
        int valor;

        while (true)
        {
            Console.WriteLine($"Informe o valor do lado {nomeLado}: ");

            bool conseguiuConverter = int.TryParse(Console.ReadLine(), out valor);

            if (conseguiuConverter)
                break;
        }

        return valor;
    }

    static void ExibirValoresInformados (int ladoX, int ladoY, int ladoZ)
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Valores informados:");
        Console.WriteLine("Lado X: " + ladoX);
        Console.WriteLine("Lado Y: " + ladoY);
        Console.WriteLine("Lado Z: " + ladoZ);
        Console.WriteLine("-------------------------------------");
    }
}
