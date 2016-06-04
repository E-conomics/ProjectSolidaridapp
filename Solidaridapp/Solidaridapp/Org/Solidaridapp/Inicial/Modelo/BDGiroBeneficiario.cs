using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidaridapp.Org.Solidaridapp.Inicial.Modelo
{
    public class BDGiroBeneficiario
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int idPersona { get; set; }


        [SQLite.MaxLength(50)]
        public string descripcion { get; set; }
    }
}
