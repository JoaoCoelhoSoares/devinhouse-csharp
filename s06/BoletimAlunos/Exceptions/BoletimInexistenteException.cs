namespace BoletimNamespace.Exceptions
{
    public class BoletimInexistenteException : Exception
    {
        private const string Mensagem = "O aluno não possui boletim.";

        public BoletimInexistenteException() : base(
            string.Format(Mensagem))
        {
        }

        public BoletimInexistenteException(Exception innerException) : base(
         string.Format(Mensagem), innerException)
        {
        }

    }
}