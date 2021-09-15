using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string opcaoUsuario = ObterOpcaoUsuario();

            // toUpper, mesmo que o usuario informe um x minusculo, transforma em maiuscula para ser feita a comparação
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        // instanciando um objeto do tipo Aluno
                        var aluno = new Aluno();
                        // pegando do console e colocando dentro do objeto
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("informe a nota do aluno:");

                        // var é uma  declaracao de variavel sem tipo, que pega o tipo que o proprio valor representa
                        var nota = decimal.Parse(Console.ReadLine());
                        break;
                    case "2":
                        //TODO: listar alunos
                        break;
                    case "3":
                        //TODO: calcular media geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            // leia novamente a opção do usuario
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}