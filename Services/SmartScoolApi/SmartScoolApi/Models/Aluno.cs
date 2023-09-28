namespace SmartScoolApi.Models
{
    public class Aluno
    {
        public Aluno(int id, string name, string sobrenome, string telefone)
        {
            Id = id;
            Name = name;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
        public Aluno()
        {

        }

        public int Id { get; set; } 
        public string Name { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        public int DisciplinaId { get; set; }
    }
}
