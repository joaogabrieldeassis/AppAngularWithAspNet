using SmartScoolApi.Domain.DomainModel.Models.ValueObject;

namespace SmartScoolApi.Domain.DomainModel.Models
{
    public class Aluno : Entity
    {
        public Aluno(Guid id, NomeCompleto nomeCompleto, string telefone)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            Telefone = telefone;
        }
        public Aluno() { }

        public NomeCompleto NomeCompleto { get; set; }
        public string Telefone { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        public int DisciplinaId { get; set; }
    }
}
