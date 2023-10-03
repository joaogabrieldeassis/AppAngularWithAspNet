using SmartScoolApi.Domain.DomaiModel.Interfaces;
using SmartScoolApi.Domain.DomainModel.Models;

namespace SmartScoolApi.Domain.Interfaces
{
    public interface IProfessoresRepository : IRepository<Professor>
    {
        public Task<Professor> ObterProfessoresESuasDisciplinas(Guid id);
    }
}
