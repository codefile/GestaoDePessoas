using System.ComponentModel.DataAnnotations.Schema;
using GestaoDePessoas.Entities.Enumerators;
using GestaoDePessoas.Entities.TiposJuridicos;

namespace GestaoDePessoas.Entities.Pessoas
{
    public class Contato : Pessoa
    {
        public long IdPessoaJuridica { get; set; }

        [ForeignKey("IdPessoaJuridica")]
        public PessoaFisica Empresa { get; set; }

        public Contato(ETiposJuridicos tipoJuridico = ETiposJuridicos.PF) : base(tipoJuridico)
        {
        }
    }
}
