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
        public int idAportacion { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public Benefactor Benefactor { get; set; }
        public Beneficiario Beneficiario { get; set; }
        public enum TipoAportacion { especie, servicio };
        public string ValorMonetarioAproximado { get; set; }
    }
}
