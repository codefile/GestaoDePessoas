using System.Data.Entity.ModelConfiguration;
using GestaoDePessoas.Entities.Pessoas;

namespace GestaoDePessoas.DataAccess.Mapping
{
    public class UsuarioMapping:ComplexTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            Property(t => t.AcessaSistema).HasColumnName("AcessaSistema");
            Property(t => t.DataValidade).HasColumnName("DataValidade");
            Property(t => t.Login).HasColumnName("Login").HasMaxLength(15);
            Property(t => t.Senha).HasColumnName("Senha");
        }
    }
}
