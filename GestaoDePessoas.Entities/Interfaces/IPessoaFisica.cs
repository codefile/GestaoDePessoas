
using System;

namespace GestaoDePessoas.Entities.Interfaces
{
    public interface IPessoaFisica
    {
        string Cpf { get; set; }
        string Apelido { get; set; }
        DateTime? Aniversario { get; set; }

        bool ValidarCpf();
        int RetornarIdade();
    }
}
