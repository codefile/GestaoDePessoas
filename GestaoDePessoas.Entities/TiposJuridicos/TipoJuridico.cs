using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoDePessoas.Entities.TiposJuridicos
{
    [Table("PessoasTiposComplementos")]
    public abstract class TipoJuridico
    {
        [Key]
        public long Id { get; set; } 
    }
}
