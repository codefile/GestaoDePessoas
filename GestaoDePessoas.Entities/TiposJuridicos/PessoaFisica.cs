using System.Globalization;
using GestaoDePessoas.Entities.Interfaces;
using CommomObjects.Functions;
using System;
using GestaoDePessoas.Entities.Pessoas;

namespace GestaoDePessoas.Entities.TiposJuridicos
{
    public class PessoaFisica : TipoJuridico, IPessoaFisica
    {
        public PessoaFisica()
        {
            Usuario = new Usuario
            {
                AcessaSistema = false
            };
        }

        private string _cpf;

        public string Cpf
        {
            get
            {
                //TODO: Criar formataçao para CPF
                return _cpf.ToString(CultureInfo.InvariantCulture);
            }
            set
            {
                _cpf = value;
            }
        }

        public int IdCargo { get; set; }
        public virtual Cargo Cargo { get; set; }

        public string Apelido { get; set; }
        public DateTime? Aniversario { get; set; }
        public Usuario Usuario { get; set; }

        public bool ValidarCpf()
        {
            return !string.IsNullOrEmpty(Cpf) && ValidatorsHelp.ValidaCpf(Cpf);
        }

        public int RetornarIdade()
        {
            return Aniversario != null ? DateTime.Parse(Aniversario.ToString()).CalcularIdade() : 0;
        }
    }
}
