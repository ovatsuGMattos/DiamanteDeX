namespace DiamanteDeX.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirBoasVindas();

            int numeroDigitado = SolicitarNumeroImpar();

            if (numeroDigitado % 2 == 0)
            {
                Console.WriteLine("Número inválido. Certifique-se de imputar um número ímpar.");
                return;
            }

            ExibirDiamante(numeroDigitado);

            Console.ReadLine();
        }

        static void ExibirBoasVindas()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Seja bem vindo ao Diamante de X");
            Console.WriteLine("-------------------------------");
        }

        static int SolicitarNumeroImpar()
        {
            Console.WriteLine("Digite o número ÍMPAR desejado");
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }

        static void ExibirDiamante(int numero)
        {
            int contador = 1;

            while (contador < numero)
            {
                ExibirLinhaDiamante(numero, contador);
                contador += 2;
            }

            ExibirLinhaDiamante(numero, numero);

            contador -= 2;
            while (contador > 0)
            {
                ExibirLinhaDiamante(numero, contador);
                contador -= 2;
            }
        }

        static void ExibirLinhaDiamante(int numero, int contador)
        {
            int espacos = (numero - contador) / 2;

            for (int i = 0; i < espacos; i++)
            {
                Console.Write(" ");
            }

            for (int i = 1; i <= contador; i++)
            {
                Console.Write("x");
            }

            Console.WriteLine();
        }
    }
}
