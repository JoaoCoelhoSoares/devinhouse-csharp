namespace BoletimNamespace.Exceptions
{
    public class OpcaoAlunoInvalidaException : Exception
    {
        private const string Mensagem = "O valor informado não corresponde a nenhum aluno.";

        public OpcaoAlunoInvalidaException() : base(
            string.Format(Mensagem))
        {
        }

        public OpcaoAlunoInvalidaException(Exception innerException) : base(
         string.Format(Mensagem), innerException)
        {
        }
    }
}