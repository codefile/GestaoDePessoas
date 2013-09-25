using System;

namespace GestaoDePessoas.Entities.Enumerators
{
    [Flags]
    public enum ETiposJuridicos
    {
        [EnumDescription("Pessoa Física")]
        PF = 1,
        [EnumDescription("Pessoa Jurídica")]
        PJ = 2  
    }
}
