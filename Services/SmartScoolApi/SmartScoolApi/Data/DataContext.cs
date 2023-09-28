using Microsoft.EntityFrameworkCore;
using SmartScoolApi.Models;
using System;

namespace SmartScoolApi.Data
{
    public class DataContext : DbContext
    {
        private readonly StreamWriter _logStream = new StreamWriter("mylog.txt", append: true);
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options
                .UseSqlServer("Server=localhost,1433;Database=AppFullStack;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;")
                .EnableSensitiveDataLogging()
                .LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
        public override void Dispose()
        {
            base.Dispose();
            _logStream.Dispose();
        }
    }
}
