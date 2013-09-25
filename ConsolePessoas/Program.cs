using GestaoDePessoas.DataAccess;

namespace ConsolePessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Contexto();
            ctx.Database.Delete();
            ctx.Database.CreateIfNotExists();
        }
    }
}
