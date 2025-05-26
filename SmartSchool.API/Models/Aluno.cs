
namespace SmartSchool.API.Models
{
    public class Aluno
    {
        public Aluno()
        {

        }
        public Aluno(int id, string sobrenome)
        {
            this.Id = id;
            this.Sobrenome = sobrenome;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }

    }
}