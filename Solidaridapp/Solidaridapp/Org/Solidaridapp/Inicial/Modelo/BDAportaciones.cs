using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidaridapp.Org.Solidaridapp.Inicial.Modelo
{
    public class BDAportaciones
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int idAportaciones { get; set; }

        [SQLite.MaxLength(50)]
        public string fecha { get; set; }

        [SQLite.MaxLength(50)]
        public string hora { get; set; }

        [ForeignKey(typeof(BdBenefactor))]
        public int idBenefactor { get; set; }

        [ForeignKey(typeof(BDBeneficiario))]
        public int idBeneficiario { get; set; }

        [SQLite.MaxLength(50)]
        public string tipo { get; set; }

        public int valorAprox { get; set; }
    }
}
