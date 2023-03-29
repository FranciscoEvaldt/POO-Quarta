using System;
using System.Collections.Generic;

namespace Aula_04{
    class Program{
        static List<Pessoa> listaPessoas = new List<Pessoa>();
        PersonRepository personRepository = new PersonRepository()
        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar pessoa");
                Console.WriteLine("2 - Listar pessoas");
                Console.WriteLine("3 - Atualizar pessoa");
                Console.WriteLine("4 - Remover pessoa");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarPessoa();
                        break;
                    case 2:
                        ListarPessoas();
                        break;
                    case 3:
                        AtualizarPessoa();
                        break;
                    case 4:
                        RemoverPessoa();
                        break;
                    case 0:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}    