namespace SmartScoolApi.Domain.Models
{
    public class Professor : Entity
    {
        public Professor(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public Professor() { }

        public string Nome { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
    }
}
