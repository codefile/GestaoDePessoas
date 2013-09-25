using System;
using System.Collections.Generic;
using System.Linq;
using CommomObjects.Interfaces;
using GenericRepository;
using GestaoDePessoas.DataAccess.Repositories.Interfaces;
using GestaoDePessoas.Entities.Enumerators;
using GestaoDePessoas.Entities.Pessoas;
using GestaoDePessoas.Entities.TiposJuridicos;
using EnumHelper = CommomObjects.Functions.MyEnumHelper;

namespace GestaoDePessoas.DataAccess.Repositories
{
    public class RepositorioGerenciamentoDePessoas : GenericRepository<Contexto>, IRepositorioGerenciamentoDePessoas
    {

        public IDictionary<int, string> ListarTiposJuridicos()
        {
            IDictionary<int, string> dic = new Dictionary<int, string>();

            foreach (var item in EnumHelper.EnumToDictionary<ETiposJuridicos>())
            {
                dic.Add(item.Key, ((ETiposJuridicos) item.Key).GetDescription());
            }

            return dic;
        }

        public IEnumerable<Pessoa> ListarUsuariosDoSistema()
        {
            return
                Context.Pessoas.Where(
                    one =>
                        one.TipoJuridico != null
                        && one.TipoJuridico.GetType() == typeof (PessoaFisica)
                        && ((PessoaFisica) one.TipoJuridico).Usuario != null
                        && ((PessoaFisica) one.TipoJuridico).Usuario.AcessaSistema);
        }

        public IEnumerable<Pessoa> ListarPessoas(ICriteria criteria)
        {
            IQueryable<Pessoa> query = Context.Pessoas;
            if (criteria.IsSearch)
            {
                var value = criteria.GetFieldData(criteria.FilterColumn);
                query = query.Where(one => one.Nome.Contains(value));
            }

            if (criteria.SortColumn == "Nome" && criteria.SortOrder == "asc")
                query = query.OrderBy(one => one.Nome);
            else if (criteria.SortColumn == "Nome" && criteria.SortOrder == "desc")
                query = query.OrderByDescending(o => o.Nome);
            else
                query = query.OrderBy(o => o.Nome);

            return query.Skip((criteria.PageIndex - 1)*criteria.PageSize).Take(criteria.PageSize);
        }

        public IEnumerable<Pessoa> ListarClientes(ICriteria criteria)
        {
            var query = Context.Pessoas.Where(w=> w.GetType() == typeof(Cliente));
            if (criteria.IsSearch)
            {
                var value = criteria.GetFieldData(criteria.FilterColumn);
                query = query.Where(one => one.Nome.Contains(value));
            }

            if (criteria.SortColumn == "Nome" && criteria.SortOrder == "asc")
                query = query.OrderBy(one => one.Nome);
            else if (criteria.SortColumn == "Nome" && criteria.SortOrder == "desc")
                query = query.OrderByDescending(o => o.Nome);
            else
                query = query.OrderBy(o => o.Nome);

            return query.Skip((criteria.PageIndex - 1) * criteria.PageSize).Take(criteria.PageSize);
        }

        public IEnumerable<Pessoa> ListarFornecedores(ICriteria criteria)
        {
            var query = Context.Pessoas.Where(w => w.GetType() == typeof(Fornecedor));
            if (criteria.IsSearch)
            {
                var value = criteria.GetFieldData(criteria.FilterColumn);
                query = query.Where(one => one.Nome.Contains(value));
            }

            if (criteria.SortColumn == "Nome" && criteria.SortOrder == "asc")
                query = query.OrderBy(one => one.Nome);
            else if (criteria.SortColumn == "Nome" && criteria.SortOrder == "desc")
                query = query.OrderByDescending(o => o.Nome);
            else
                query = query.OrderBy(o => o.Nome);

            return query.Skip((criteria.PageIndex - 1) * criteria.PageSize).Take(criteria.PageSize);
        }

        public IEnumerable<Pessoa> ListarColaboradores(ICriteria criteria)
        {
            var query = Context.Pessoas.Where(w => w.GetType() == typeof(Colaborador));
            if (criteria.IsSearch)
            {
                var value = criteria.GetFieldData(criteria.FilterColumn);
                query = query.Where(one => one.Nome.Contains(value));
            }

            if (criteria.SortColumn == "Nome" && criteria.SortOrder == "asc")
                query = query.OrderBy(one => one.Nome);
            else if (criteria.SortColumn == "Nome" && criteria.SortOrder == "desc")
                query = query.OrderByDescending(o => o.Nome);
            else
                query = query.OrderBy(o => o.Nome);

            return query.Skip((criteria.PageIndex - 1) * criteria.PageSize).Take(criteria.PageSize);
        }

        public IEnumerable<Pessoa> ListarContatos(ICriteria criteria, PessoaJuridica pessoaJuridica)
        {
            var query = Context.Pessoas.Where(w => w.GetType() == typeof(Contato) && ((Contato)w).IdPessoaJuridica == pessoaJuridica.Id);

            if (criteria.IsSearch)
            {
                var value = criteria.GetFieldData(criteria.FilterColumn);
                query = query.Where(one => one.Nome.Contains(value));
            }

            if (criteria.SortColumn == "Nome" && criteria.SortOrder == "asc")
                query = query.OrderBy(one => one.Nome);
            else if (criteria.SortColumn == "Nome" && criteria.SortOrder == "desc")
                query = query.OrderByDescending(o => o.Nome);
            else
                query = query.OrderBy(o => o.Nome);

            return query.Skip((criteria.PageIndex - 1) * criteria.PageSize).Take(criteria.PageSize);
        }



        public int RetornarTotalPessoas(eTiposPessoas tipoPessoa)
        {
            switch (tipoPessoa)
            {
                case eTiposPessoas.Cliente:
                    return Context.Pessoas.Count(w => w.GetType() == typeof (Cliente));
                case eTiposPessoas.Colaborador:
                    return Context.Pessoas.Count(w => w.GetType() == typeof (Colaborador));
                case eTiposPessoas.Contato:
                    return Context.Pessoas.Count(w => w.GetType() == typeof (Contato));
                default:
                    throw new NotImplementedException("Não implementado para este tipo de Pessoa");
            }
        }

        public int RetornarTotalPessoas()
        {
            return Context.Pessoas.Count();
        }

        public Pessoa SelecionarPessoa(int id)
        {
            return Context.Pessoas.FirstOrDefault(one => one.Id == id);
        }
    }
}
