using System;

namespace GestaoDePessoas.Entities.Enumerators
{
    [Flags]
    public enum eTiposPessoas
    {
        [EnumDescription("Cliente")]
        Cliente = 1,
        [EnumDescription("Fornecedor")]
        Fornecedor,
        Colaborador,
        Contato
    }
}
