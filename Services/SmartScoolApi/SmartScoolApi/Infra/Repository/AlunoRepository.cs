using Microsoft.EntityFrameworkCore.Update;
using SmartScoolApi.Data;
using SmartScoolApi.Domain.DomainModel.Models;
using SmartScoolApi.Domain.DomaiModel.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SmartScoolApi.Infra.Repository
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(DataContext context) : base(context)
        {

        }

        public async Task<Aluno> GetAlunosByDisciplinas(Guid disciplinaId)
        {
            return await _context.Alunos.AsTracking().Where(c => c.Id == disciplinaId).Include(c => c.Disciplinas).FirstOrDefaultAsync();
        }
    }
}
