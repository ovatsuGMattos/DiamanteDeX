namespace DiamanteDeX.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //O programa deve solicitar ao usuário um número inteiro.

            Console.WriteLine("Digite o número ÍMPAR desejado");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());
            int espaco = numeroDigitado;
            int contador = 1;

            //O número deve ser ímpar. Caso contrário, o programa deve informar que a entrada é inválida e solicitar um novo número.
            if (numeroDigitado % 2 > 0)
            {

                while (contador < numeroDigitado)
                {
                    //Lógica de espaçamento antes dos X's
                    for (int i = 0; i < ((numeroDigitado - contador)/ 2); i++)
                    {
                        Console.Write(" ");
                    }
                    for (int i = 1; i <= contador; i++)
                    {
                        Console.Write("x");
                    }

                    contador = contador + 2;
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Número inválido, certifique de imputar um número ÍMPAR");

            }
            //O número de linhas e colunas deve ser igual ao número ímpar fornecido.
            //A linha central do diamante deve conter o número máximo de 'X's.

            Console.ReadLine();

        }

    }
}
