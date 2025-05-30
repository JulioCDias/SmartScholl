using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;

namespace SmartSchool.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Aluno> alunos { get; set; }
        public DbSet<Professor> professores { get; set; }
        public DbSet<Disciplina> disciplinas { get; set; }
        public DbSet<AlunoDisciplina> alunoDisciplinas { get; set; }
    }
}