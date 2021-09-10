// qual grupo de ferramentas estou utilizando 
// pacote proprio do dotnet
// importando do dotnet
using System;

namespace DigitalInnovationOne
{
    class Program
    {
        // metodo construtor da classe program
        static void Main(string[] args)
        {
            int numeroDeVezes = 5;

            for(int i=0; i < numeroDeVezes; i++)
            // $ funcionalidade de c#
            {
                Console.WriteLine($"Bem vindo ao curso de .NET {i}");
            }
        }
    }
}
