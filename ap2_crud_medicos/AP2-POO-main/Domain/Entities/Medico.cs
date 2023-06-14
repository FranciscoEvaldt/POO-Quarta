using System.Collections.Generic;

namespace ap2_crud_medicos.Domain.Entities
{
  public class Medico : Pessoa
  {
    public string CRM { get; set; }
    public string Especialidade { get; set; }
    public List<Consulta> Consultas { get; set; } = new List<Consulta>();
  }
}
