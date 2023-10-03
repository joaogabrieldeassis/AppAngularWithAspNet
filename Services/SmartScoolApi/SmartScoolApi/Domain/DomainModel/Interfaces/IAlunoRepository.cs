using SmartScoolApi.Domain.DomainModel.Models;

namespace SmartScoolApi.Domain.DomaiModel.Interfaces
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        public Task<Aluno> GetAlunosByDisciplinas(Guid disciplinaId);
    }
}
