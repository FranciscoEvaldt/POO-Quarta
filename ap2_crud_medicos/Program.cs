﻿using System;
using ap2_crud_medicos.Controllers;
using ap2_crud_medicos.Domain.Entities;
using ap2_crud_medicos.Domain.Interfaces;
using ap2_crud_medicos.Data.Repositories;

namespace ap2_crud_medicos
{
  class Program
  {
    static void Main(string[] args)
    {
      int opcao = 0;
      IMedicoRepository medicoRepository = new MedicoRepository();
      MedicoController medicoController = new MedicoController(medicoRepository);


      while (opcao != 6)
      {
        Console.WriteLine("Selecione uma opção:");
        Console.WriteLine("1 - Adicionar médico");
        Console.WriteLine("2 - Listar médicos");
        Console.WriteLine("3 - Verificar disponibilidade de médico");
        Console.WriteLine("4 - Marcar consulta");
        Console.WriteLine("5 - Excluir médico");
        Console.WriteLine("6 - Sair");

        if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 6)
        {
          Console.WriteLine("Opção inválida. Tente novamente.");
          continue;
        }

        switch (opcao)
        {
          case 1:
            medicoController.AdicionarMedico();
            break;
          case 2:
            medicoController.ListarMedicos();
            break;
          case 3:
            medicoController.VerificarDisponibilidadeMedico();
            break;
          case 4:
            medicoController.MarcarConsulta();
            break;
          case 5:
            medicoController.ExcluirMedico();
            break;
          case 6:
            Console.WriteLine("Saindo do programa...");
            break;
        }
      }
    }
  }
}
