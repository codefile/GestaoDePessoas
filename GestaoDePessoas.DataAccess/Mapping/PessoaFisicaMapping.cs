using System.Data.Entity.ModelConfiguration;
using GestaoDePessoas.Entities.TiposJuridicos;

namespace GestaoDePessoas.DataAccess.Mapping
{
    public class PessoaFisicaMapping : EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaMapping()
        {
            //Keys
            HasKey(t => t.Cpf);

            HasOptional(t => t.Cargo).WithMany(t => t.PessoasFisicas).HasForeignKey(d => d.IdCargo);
        }
    }
}
