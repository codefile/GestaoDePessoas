using System.Collections.Generic;
using CommomObjects.Interfaces;
using GestaoDePessoas.Entities.Enumerators;
using GestaoDePessoas.Entities.Pessoas;
using GestaoDePessoas.Entities.TiposJuridicos;

namespace GestaoDePessoas.DataAccess.Repositories.Interfaces
{
    public interface IRepositorioGerenciamentoDePessoas : GenericRepository.Interfaces.IGerericRepository
    {
        IEnumerable<Pessoa> ListarPessoas(ICriteria criteria);
        IEnumerable<Pessoa> ListarClientes(ICriteria criteria);
        IEnumerable<Pessoa> ListarFornecedores(ICriteria criteria);
        IEnumerable<Pessoa> ListarContatos(ICriteria criteria, PessoaJuridica pessoaJuridica);

        int RetornarTotalPessoas(eTiposPessoas tipoPessoa);
        int RetornarTotalPessoas();

        Pessoa SelecionarPessoa(int id);
    }
}
