using System;
using System.Collections.Generic;
using System.Linq;
using ap2_crud_medicos.Data;
using ap2_crud_medicos.Domain.Entities;
using ap2_crud_medicos.Domain.Interfaces;

namespace ap2_crud_medicos.Data.Repositories
{
  public class MedicoRepository : IMedicoRepository
  {
    private DataContext context;

    public MedicoRepository()
    {
      context = new DataContext();
    }

    public void AdicionarMedico(Medico medico)
    {
      context.Medicos.Add(medico);
      context.SaveChanges();
    }

    public void ExcluirMedico(Medico medico)
    {
      context.Medicos.Remove(medico);
      context.SaveChanges();
    }

    public List<Medico> ListarMedicos()
    {
      return context.Medicos.ToList();
    }

    public bool VerificarDisponibilidadeMedico(Medico medico, DateTime dataConsulta)
    {
      bool disponivel = !context.Consultas.Any(c => c.Medico == medico && c.DataConsulta == dataConsulta);
      return disponivel;
    }

    public void MarcarConsulta(Medico medico, Paciente paciente, DateTime dataHora)
    {
      bool disponivel = VerificarDisponibilidadeMedico(medico, dataHora);

      if (disponivel)
      {
        Consulta consulta = new Consulta
        {
          Medico = medico,
          Paciente = paciente,
          DataConsulta = dataHora
        };

        context.Consultas.Add(consulta);
        context.SaveChanges();
      }
      else
      {
        Console.WriteLine("Médico não está disponível na data e hora especificadas.");
      }
    }

    public void AtualizarMedico(Medico medico)
    {
      context.Medicos.Update(medico);
      context.SaveChanges();
    }
  }
}
