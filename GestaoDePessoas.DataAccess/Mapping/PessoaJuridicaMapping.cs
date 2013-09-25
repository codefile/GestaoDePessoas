using System.Data.Entity.ModelConfiguration;
using GestaoDePessoas.Entities.TiposJuridicos;

namespace GestaoDePessoas.DataAccess.Mapping
{
    public class PessoaJuridicaMapping : EntityTypeConfiguration<PessoaJuridica>
    {
        public PessoaJuridicaMapping()
        {
            //Keys
            HasKey(t => t.Cnpj);

            HasOptional(t => t.Porte).WithMany(t => t.PessoasJuridicas).HasForeignKey(d => d.IdPorte);
        }
    }
}
