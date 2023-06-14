using System.Collections.Generic;

namespace ap2_crud_medicos.Domain.Entities
{
  public class Paciente : Pessoa
  {
    public List<Consulta> Consultas { get; set; } = new List<Consulta>();
  }
}
