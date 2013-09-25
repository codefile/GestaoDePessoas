using System.Security.Cryptography.X509Certificates;
using GestaoDePessoas.Entities.Enumerators;

namespace GestaoDePessoas.Entities.Pessoas
{
    public class Colaborador : Pessoa
    {
        /// <summary>
        /// Construtor da classe.
        /// </summary>
        /// <param name="tipoJuridico">Passa o Tipo Jurídico, PF ou PJ</param>
        public Colaborador(ETiposJuridicos tipoJuridico) : base(tipoJuridico)
        {
            
        }
    }
}
