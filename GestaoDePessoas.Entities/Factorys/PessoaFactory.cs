using GestaoDePessoas.Entities.Enumerators;
using GestaoDePessoas.Entities.Pessoas;

namespace GestaoDePessoas.Entities.Factorys
{
    public class PessoaFactory
    {
        public Pessoa CriarEntidadePessoa(ETiposJuridicos tipoJuridico, eTiposPessoas tipoPessoa)
        {
            switch (tipoPessoa)
            {
                case eTiposPessoas.Cliente:
                    return new Cliente(tipoJuridico);
                case eTiposPessoas.Colaborador:
                    return new Colaborador(tipoJuridico);
                case eTiposPessoas.Contato:
                    return new Contato();
                case eTiposPessoas.Fornecedor:
                    return new Fornecedor(tipoJuridico);
                default:
                    return null;
            }
        }
    }
}
