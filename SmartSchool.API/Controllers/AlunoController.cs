using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        /// <summary>
        /// Controller para gerenciar alunos.
        /// Este controller é responsável por fornecer endpoints relacionados a operações de alunos,
        /// </summary>
        public List<Aluno> Alunos { get; set; } = new List<Aluno>()
        {
            new Aluno() {
                Id = 1,
                Nome = "João",
                Sobrenome = "da Silva",
                Telefone = "123456789"
            },
            new Aluno() {
                Id = 2,
                Nome = "Maria",
                Sobrenome = "Oliveira",
                Telefone = "987654321"
            },
            new Aluno() {
                Id = 3,
                Nome = "Pedro",
                Sobrenome = "Santos",
                Telefone = "456789123"
            }
        };
        public AlunoController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
            {
                return NotFound($"Aluno com ID {id} não encontrado.");
            }
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}