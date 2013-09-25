using GestaoDePessoas.Entities.Enumerators;

namespace GestaoDePessoas.Entities.Pessoas
{
    public class Cliente : Pessoa
    {
        public Cliente(ETiposJuridicos tipoJuridico) : base(tipoJuridico)
        {
        }
    }
}
