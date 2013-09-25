
namespace GestaoDePessoas.Entities.Interfaces
{
    public interface IPessoaJuridica
    {
        string Cnpj { get; set; }
        string RazaoSocial { get; set; }
        string InscricaoEstadual { get; set; }
        string InscricaoMunicipal { get; set; }
        string NomeFantasia { get; set; }

        bool ValidarCnpj();
    }
}
