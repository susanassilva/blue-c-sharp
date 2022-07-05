namespace Agenda.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Apelido { get; set; }
        public DateTime DataNascimento { get; set; }

        public char Genero { get; set; }

        public int Endereco_Id { get; set; }

        #region Navigation Properties
        public virtual Endereco Endereco { get; set; }

        #endregion
    }
}
