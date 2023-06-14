using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ap2_crud_medicos.Domain.Entities
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime DataConsulta { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
    }
}