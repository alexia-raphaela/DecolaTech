using System;
using EstruturaDoPrograma.Exemplos;

namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {
            // instancio a varivel s como nova pilha
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}