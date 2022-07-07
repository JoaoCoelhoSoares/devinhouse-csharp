namespace BoletimNamespace.Dominio
{
    public class Boletim
    {
        public Disciplina DisciplinaBoletim { get; private set; }
        public float MediaNotas { get; private set; }
        public float[] Notas { get; set; }

        public Boletim(Disciplina disciplinaBoletim, float[] notas)
        {
            this.DisciplinaBoletim = disciplinaBoletim;
            this.Notas = notas;
            this.MediaNotas = Notas.Average();
        }
    }
}