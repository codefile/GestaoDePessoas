using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommomObjects;
using GestaoDePessoas.Entities.TiposJuridicos;

namespace GestaoDePessoas.Entities
{
    public class Porte : BaseEntity
    {
        public string Descricao { get; set; }
        public virtual ICollection<PessoaJuridica> PessoasJuridicas { get; set; }
    }
}
