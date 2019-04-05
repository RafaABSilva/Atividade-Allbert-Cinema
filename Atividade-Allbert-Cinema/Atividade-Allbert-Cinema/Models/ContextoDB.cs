using MySql.Data.Entity;
using System.Data.Entity;

namespace Atividade_Allbert_Cinema.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ContextoDB : DbContext
    {
        public ContextoDB()
        //Reference the name of your connection string ( WebAppCon )
        : base("StringConexaoBD") { }
    }
}