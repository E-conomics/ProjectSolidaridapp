using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidaridapp.Org.Solidaridapp.Inicial.Modelo
{
    public class BdBenefactor
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int idBenefactor { get; set; }

        [ForeignKey(typeof(BDUsuario))]
        public int idUsuario { get; set; }

    }
}
