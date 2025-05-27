using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Professor
    {
        public Professor()
        {

        }
        public Professor(int id, string sobrenome)
        {
            this.Id = id;
            this.Sobrenome = sobrenome;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }
    }
}