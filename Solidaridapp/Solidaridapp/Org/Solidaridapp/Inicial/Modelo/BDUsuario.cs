using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidaridapp.Org.Solidaridapp.Inicial.Modelo
{
    class BDUsuario
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int idPersona { get; set; }

        [SQLite.MaxLength(50)]
        public string correo { get; set; }

        [SQLite.MaxLength(50)]
        public string telefono { get; set; }

        [SQLite.MaxLength(50)]
        public string clave { get; set; }

        [SQLite.MaxLength(50)]
        public string Auth { get; set; }
    }
}
