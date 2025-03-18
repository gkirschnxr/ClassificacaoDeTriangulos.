namespace ClassificacaoDeTriangulos.ConsoleApp;

static class ClassificadorDeTriangulos
{
    public static bool ValidacaoDeTriangulo(int ladoX, int ladoY, int ladoZ)
    {
        bool medidasTriangulosValidas =
            ladoX + ladoY > ladoZ &&
            ladoY + ladoZ > ladoX &&
            ladoZ + ladoX > ladoY;

        return medidasTriangulosValidas;
    }

    public static string ClassificarTriangulo(int ladoX, int ladoY, int ladoZ)
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

        return tipoTriangulo;
    }
}
