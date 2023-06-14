using ap2_crud_medicos.Data.Repositories;
using ap2_crud_medicos.Domain.Entities;
using ap2_crud_medicos.Domain.Interfaces;


namespace ap2_crud_medicos.Controllers
{
    public class MedicoController
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoController(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        public void AdicionarMedico()
        {
            Medico medico = new Medico();
            Console.WriteLine("Digite o nome do médico:");
            medico.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do médico:");
            medico.CPF = Console.ReadLine();
            Console.WriteLine("Digite o CRM do médico:");
            medico.CRM = Console.ReadLine();
            Console.WriteLine("Digite a especialidade do médico:");
            medico.Especialidade = Console.ReadLine();

            try
            {
                _medicoRepository.AdicionarMedico(medico);
                Console.WriteLine("Médico adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao adicionar o médico: " + ex.Message);
            }
        }

        public void ListarMedicos()
        {
            List<Medico> medicos = _medicoRepository.ListarMedicos();

            if (medicos.Count == 0)
            {
                Console.WriteLine("Não há médicos cadastrados.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Médicos cadastrados:");
                Console.WriteLine("");

                foreach (Medico medico in medicos)
                {
                    Console.WriteLine("Nome: {0}\nCPF: {1}\nCRM: {2}\nEspecialidade: {3}",
                    medico.Nome, medico.CPF, medico.CRM, medico.Especialidade);
                    Console.WriteLine("");
                }
            }
        }

        
        public void VerificarDisponibilidadeMedico()
        {
            Console.WriteLine("Digite o CRM do médico:");
            string crm = Console.ReadLine();
            Medico medico = _medicoRepository.ListarMedicos().FirstOrDefault(m => m.CRM == crm);
            if (medico == null)
            {
                Console.WriteLine("Médico não encontrado.");
            }
            else
            {
                Console.WriteLine("Digite a data e hora da consulta (formato: dd/mm/yyyy hh:mm):");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime dataHora))
                {
                    Console.WriteLine("Data e hora inválidas. Tente novamente.");
                    return;
                }
                if (_medicoRepository.VerificarDisponibilidadeMedico(medico, dataHora))
                {
                    Console.WriteLine("Médico disponível na data e hora selecionadas.");
                }
                else
                {
                    Console.WriteLine("Médico não disponível na data e hora selecionadas.");
                }
            }
        }

        public void MarcarConsulta()
        {
            Console.WriteLine("Digite o CPF do paciente:");
            string cpf = Console.ReadLine();
            Paciente paciente = new Paciente() { CPF = cpf };
            Console.WriteLine("Digite o CRM do médico:");
            string crm = Console.ReadLine();
            Medico medico = _medicoRepository.ListarMedicos().FirstOrDefault(m => m.CRM == crm);
            if (medico == null)
            {
                Console.WriteLine("Médico não encontrado.");
            }
            else
            {
                Console.WriteLine("Digite a data e hora da consulta (formato: dd/mm/yyyy hh:mm):");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime dataHora))
                {
                    Console.WriteLine("Data e hora inválidas. Tente novamente.");
                    return;
                }
                try
                {
                    _medicoRepository.MarcarConsulta(medico, paciente, dataHora);
                    Console.WriteLine("Consulta marcada com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void ExcluirMedico()
        {
            Console.WriteLine("Digite o CRM do médico a ser excluído:");
            string crm = Console.ReadLine();
            Medico medico = _medicoRepository.ListarMedicos().FirstOrDefault(m => m.CRM == crm);

            if (medico == null)
            {
                Console.WriteLine("Médico não encontrado.");
            }
            else
            {
                _medicoRepository.ExcluirMedico(medico);
                Console.WriteLine("Médico excluído com sucesso!");
            }
        }
    }
}
