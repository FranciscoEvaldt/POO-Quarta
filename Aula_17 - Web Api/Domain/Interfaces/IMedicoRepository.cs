using System.Collections.Generic;
using ap2_crud_medicos.Domain.Entities;

namespace ap2_crud_medicos.Domain.Interfaces
{
  public interface IMedicoRepository
  {
    void AdicionarMedico(Medico medico);
    void ExcluirMedico(Medico medico);
    List<Medico> ListarMedicos();
    bool VerificarDisponibilidadeMedico(Medico medico, DateTime dataHora);
    void MarcarConsulta(Medico medico, Paciente paciente, DateTime dataHora);
    void AtualizarMedico(Medico medico);
  }

}
