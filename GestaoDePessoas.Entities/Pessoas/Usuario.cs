using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoDePessoas.Entities.Pessoas
{
    [ComplexType]
    public class Usuario
    {
        public bool AcessaSistema { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime? DataValidade { get; set; }
    }
}
