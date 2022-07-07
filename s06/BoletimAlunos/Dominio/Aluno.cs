namespace BoletimNamespace.Dominio
{
    public class Aluno
    {
        public int NumeroChamada { get; private set; }
        public string NomeAluno { get; private set; }

        public List<Boletim> BoletimDisciplinasAluno { get; set; }

        public Aluno(int numeroChamada, string nomeAluno)
        {
            this.NumeroChamada = numeroChamada;
            this.NomeAluno = nomeAluno;
            this.BoletimDisciplinasAluno = new List<Boletim> { };
        }
    }
}