namespace SmartScoolApi.Domain.DomainModel.Models
{
    public class Disciplina
    {
        public Disciplina(int id, string nome, int professorId, Professor professor)
        {
            Id = id;
            Nome = nome;
            ProfessorId = professorId;
            Professor = professor;
        }
        public Disciplina() { }

        public int Id { get; set; }

        public string Nome { get; set; }

        public int ProfessorId { get; set; }

        public Professor Professor { get; set; }

        public List<Aluno> Alunos { get; set; }

        public int AlunoId { get; set; }
    }
}
