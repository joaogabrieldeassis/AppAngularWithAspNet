namespace SmartScoolApi.Models
{
    public class Professor
    {
        public Professor(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public Professor() { }

        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
    }
}
