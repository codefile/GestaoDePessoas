using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using CommomObjects;
using GestaoDePessoas.Entities.Pessoas;
using GestaoDePessoas.Entities.TiposJuridicos;

namespace GestaoDePessoas.Entities
{
    [Table("Cargos")]
    public class Cargo : BaseEntity
    {
        public string Descricao { get; set; }
        public virtual ICollection<PessoaFisica> PessoasFisicas { get; set; }
    }
}
