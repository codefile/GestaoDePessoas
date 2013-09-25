using GestaoDePessoas.Entities.Interfaces;
using System.Collections.Generic;
using GestaoDePessoas.Entities.Pessoas;

namespace GestaoDePessoas.Entities.TiposJuridicos
{
    public class PessoaJuridica : TipoJuridico, IPessoaJuridica
    {

        private string _cnpj;

        public string Cnpj
        {
            get
            {
                //TODO: Criar formatacao do CNPJ com máscara
                return _cnpj;
            }
            set
            {
                _cnpj = value;
            }
        }

        public string RazaoSocial { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string NomeFantasia { get; set; }

        public int IdPorte { get; set; }
        public virtual Porte Porte { get; set; }

        public virtual ICollection<Contato> Contatos { get; set; }

        public bool ValidarCnpj()
        {
            return !string.IsNullOrEmpty(Cnpj) && CommomObjects.Functions.ValidatorsHelp.ValidarCnpj(Cnpj);
        }
    }
}
