using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;

namespace SmartSchool.API.Data
{
    public class DataContext : DbContext // minha classe Datacontenxt tem que herdar de DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) // construtor que recebe as opções de configuração do DbContext
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) //Criando ligação muitos pra muitos
        {
            builder.Entity<AlunoDisciplina>()
                .HasKey(ad => new { ad.AlunoId, ad.DisciplinaId });

            //Carga inicial de dados
            builder.Entity<Professor>().HasData(
                new Professor { Id = 1, Nome = "Gean", Sobrenome = "Silva" },
                new Professor { Id = 2, Nome = "João", Sobrenome = "Souza" },
                new Professor { Id = 3, Nome = "Maria", Sobrenome = "Oliveira" }
            );
            builder.Entity<Disciplina>().HasData(
                new Disciplina { Id = 1, Nome = "Matemática", ProfessorId = 1 },
                new Disciplina { Id = 2, Nome = "Português", ProfessorId = 2 },
                new Disciplina { Id = 3, Nome = "História", ProfessorId = 3 }
            );
            builder.Entity<Aluno>().HasData(
                new Aluno { Id = 1, Nome = "João", Sobrenome = "Silva", Telefone = "123456789" },
                new Aluno { Id = 2, Nome = "Maria", Sobrenome = "Oliveira", Telefone = "987654321" }
            );
        }
    }
}