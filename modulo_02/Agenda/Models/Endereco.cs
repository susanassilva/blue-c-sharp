namespace Agenda.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string? Logradouro { get; set; }
        public int? Numero { get; set; }
        public string? Bairro { get; set; }

        public string? Cidade { get; set; }

        public int UF_Id { get; set; }


        //navigation property
        #region Navigation Properties
        public virtual UF UF { get; set; }

        public virtual List<Contato> Contatos { get; set; }
        #endregion


            // 1 Contato pode ter 1 Endereço, 1 Endereço tem N Contato - 1:N
            // 1 Endereco pode ter 1 UF, 1 UF pode ter vários Endereços - 1:N
        }
}
