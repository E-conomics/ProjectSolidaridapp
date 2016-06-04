using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidaridapp.Org.Solidaridapp.Inicial.Modelo
{
    class BDBeneficiario
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int idBeneficiario { get; set; }

        [ForeignKey(typeof(BDUsuario))]
        public int idUsuario { get; set; }

        [SQLite.MaxLength(50)]
        public int numeroBeneficiarios { get; set; }

        [ForeignKey(typeof(BDGiroBeneficiario))]
        public int idGiro { get; set; }
    }
}
