using GestaoDePessoas.Entities.Pessoas;
using System.Data.Entity.ModelConfiguration;

namespace GestaoDePessoas.DataAccess.Mapping
{
    public class PessoasMapping : EntityTypeConfiguration<Pessoa>
    {
        public PessoasMapping()
        {
            //Propriedades
            Property(p => p.Nome).HasMaxLength(150).IsRequired();
        }
    }
}
