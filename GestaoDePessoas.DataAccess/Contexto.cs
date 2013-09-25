using System.Data.Entity;
using GestaoDePessoas.Entities.Pessoas;
using GestaoDePessoas.Entities.TiposJuridicos;

namespace GestaoDePessoas.DataAccess
{
    public class Contexto : DbContext
    {
        public Contexto() : base("PessoasDataBase")
        {
        }

        public DbSet<TipoJuridico> TiposJuridicos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Mapping.UsuarioMapping());
            modelBuilder.Configurations.Add(new Mapping.PessoasMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
