using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidaridapp.Org.Solidaridapp.Inicial.Modelo
{
    class BDPersona
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int idPersona { get; set; }

        [SQLite.MaxLength(50)]
        public string nombre { get; set; }

        [SQLite.MaxLength(50)]
        public string primerAP { get; set; }

        [SQLite.MaxLength(50)]
        public string segundoAP { get; set; }

        [SQLite.MaxLength(50)]
        public string fechaNacimiento { get; set; }

        [ForeignKey(typeof(BDUsuario))]
        public int idUsuario { get; set; }
    }
}
