using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidaridapp.Org.Solidaridapp.Inicial.Modelo
{
    class BDEmpresa
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int idEmpresa { get; set; }

        [SQLite.MaxLength(50)]
        public string nombre { get; set; }

        [SQLite.MaxLength(50)]
        public string RFC { get; set; }

        [SQLite.MaxLength(50)]
        public string calleNumero { get; set; }

        [SQLite.MaxLength(50)]
        public string colonia { get; set; }

        [SQLite.MaxLength(50)]
        public string codigoPostal { get; set; }

        [SQLite.MaxLength(50)]
        public string nombreRespresentante { get; set; }

        [SQLite.MaxLength(50)]
        public string estado { get; set; }

        [SQLite.MaxLength(50)]
        public string municipio { get; set; }

        [SQLite.MaxLength(50)]
        public string URL { get; set; }
    }
}
