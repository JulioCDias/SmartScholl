namespace SmartSchool.API.Models
{
    public class Disciplina
    {
        public Disciplina()
        {

        }
        public Disciplina(int id, int professorId)
        {
            this.Id = id;
            this.Nome = Nome;
            this.ProfessorId = professorId;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}