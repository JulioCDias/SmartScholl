using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Data;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly DataContext _context;

        public AlunoController(DataContext context)
        {
            _context = context;
        }

        // GET: api/aluno
        [HttpGet]
        public IActionResult Get()
        {
            var alunos = _context.Alunos.ToList();
            return Ok(alunos);
        }

        // GET: api/aluno/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
                return NotFound($"Aluno com ID {id} não encontrado.");

            return Ok(aluno);
        }

        // POST: api/aluno
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = aluno.Id }, aluno);
        }

        // PUT: api/aluno/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            var alunoBanco = _context.Alunos.FirstOrDefault(a => a.Id == id);
            if (alunoBanco == null)
                return NotFound($"Aluno com ID {id} não encontrado.");

            alunoBanco.Nome = aluno.Nome;
            alunoBanco.Sobrenome = aluno.Sobrenome;
            alunoBanco.Telefone = aluno.Telefone;
            // Adicione outros campos que forem necessários

            _context.SaveChanges();
            return Ok(alunoBanco);
        }

        // PATCH: api/aluno/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            var alunoBanco = _context.Alunos.FirstOrDefault(a => a.Id == id);
            if (alunoBanco == null)
                return NotFound($"Aluno com ID {id} não encontrado.");

            // Atualize apenas os campos necessários (exemplo)
            if (!string.IsNullOrEmpty(aluno.Nome))
                alunoBanco.Nome = aluno.Nome;

            if (!string.IsNullOrEmpty(aluno.Sobrenome))
                alunoBanco.Sobrenome = aluno.Sobrenome;

            if (!string.IsNullOrEmpty(aluno.Telefone))
                alunoBanco.Telefone = aluno.Telefone;

            _context.SaveChanges();
            return Ok(alunoBanco);
        }

        // DELETE: api/aluno/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
                return NotFound($"Aluno com ID {id} não encontrado.");

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
            return Ok($"Aluno com ID {id} removido com sucesso.");
        }
    }
}
