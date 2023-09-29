using SmartScoolApi.Domain.Models;

namespace SmartScoolApi.Domain.Interfaces
{
    public interface IAlunoRepository
    {
        public List<Aluno> GetAlunosByDisciplinas(Guid disciplinaId,bool includeDisciplina);
    }
}
