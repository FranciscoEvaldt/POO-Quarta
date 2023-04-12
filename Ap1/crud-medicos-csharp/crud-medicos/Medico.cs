using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_medicos
{
    public class Medico : Pessoa
    {
        private string crm;
        private string especialidade;
        private List<Consulta> consultas = new List<Consulta>();

        public string CRM {get { return crm; } set { crm = value; }}

        public string Especialidade {get { return especialidade; } set { especialidade = value; }}

        public List<Consulta> Consultas {get { return consultas; } set { consultas = value; }}
    }
}
