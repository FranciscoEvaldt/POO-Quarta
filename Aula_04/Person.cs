using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_04{
    public class person{
    

    public string ID { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }


    
    
     static void AdicionarPessoa()
    {
        Console.WriteLine("Informe o nome da pessoa:");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe o número de telefone da pessoa:");
        string telefone = Console.ReadLine();

        Pessoa pessoa = new Pessoa { ID = Guid.NewGuid().ToString(), Nome = nome, Telefone = telefone };
        listaPessoas.Add(pessoa);

        Console.WriteLine("Pessoa adicionada com sucesso!");
    }

    static void ListarPessoas()
    {
        Console.WriteLine("Lista de pessoas:");

        foreach (Pessoa pessoa in listaPessoas)
        {
            Console.WriteLine($"ID: {pessoa.ID}, Nome: {pessoa.Nome}, Telefone: {pessoa.Telefone}");
        }
    }

    static void AtualizarPessoa()
    {
        Console.WriteLine("Informe o ID da pessoa a ser atualizada:");
        string id = Console.ReadLine();

        Pessoa pessoa = listaPessoas.Find(p => p.ID == id);

        if (pessoa == null)
        {
            Console.WriteLine("Pessoa não encontrada!");
            return;
        }

        Console.WriteLine($"Nome atual: {pessoa.Nome}");
        Console.WriteLine("Informe o novo nome da pessoa:");
        string nome = Console.ReadLine();
        pessoa.Nome = nome;

        Console.WriteLine($"Telefone atual: {pessoa.Telefone}");
        Console.WriteLine("Informe o novo número de telefone da pessoa:");
        string telefone = Console.ReadLine();
        pessoa.Telefone = telefone;

        Console.WriteLine("Pessoa atualizada com sucesso!");
    }

    static void RemoverPessoa()
    {
        Console.WriteLine("Informe o ID da pessoa a ser removida:");
        string id = Console.ReadLine();

        Pessoa pessoa = listaPessoas.Find(p => p.ID == id);

        if (pessoa == null)
        {
            Console.WriteLine("Pessoa não encontrada!");
            return;
        }

        listaPessoas.Remove(pessoa);

        Console.WriteLine("Pessoa removida com sucesso!");
    }
}


}
