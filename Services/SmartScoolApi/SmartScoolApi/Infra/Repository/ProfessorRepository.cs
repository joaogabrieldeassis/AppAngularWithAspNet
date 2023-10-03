using Microsoft.EntityFrameworkCore;
using SmartScoolApi.Data;
using SmartScoolApi.Domain.DomainModel.Models;
using SmartScoolApi.Domain.Interfaces;

namespace SmartScoolApi.Infra.Repository
{
    public class ProfessorRepository : Repository<Professor>, IProfessoresRepository
    {
        public ProfessorRepository(DataContext context)
            : base(context) { }

        public async Task<Professor> ObterProfessoresESuasDisciplinas(Guid id)
        {
            return await _context.Professores.AsNoTracking().Where(c => c.Id == id).FirstOrDefaultAsync();
        }
    }
}
