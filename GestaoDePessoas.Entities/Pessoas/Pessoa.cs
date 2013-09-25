using CommomObjects;
using GestaoDePessoas.Entities.Enumerators;
using GestaoDePessoas.Entities.TiposJuridicos;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoDePessoas.Entities.Pessoas
{
    [Table("Pessoas")]
    public abstract class Pessoa : BaseEntity
    {
        public string Nome { get; set; }
        public TipoJuridico TipoJuridico { get; set; }

        public ETiposJuridicos ETipoJuridico
        {
            get
            {
                return TipoJuridico.GetType() == typeof(PessoaFisica) ? ETiposJuridicos.PF : ETiposJuridicos.PJ;
            }
        }

        protected Pessoa(ETiposJuridicos tipoJuridico)
        {
            if (tipoJuridico == ETiposJuridicos.PF)
                TipoJuridico = new PessoaJuridica();
            else
                TipoJuridico = new PessoaFisica();
        }
    }
}
