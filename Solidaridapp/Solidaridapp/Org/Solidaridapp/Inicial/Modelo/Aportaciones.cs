using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidaridapp.Org.Solidaridapp.Inicial.Modelo
{
    public class Aportaciones
    {
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public Benefactor benefactor { get; set; }
        public Beneficiario beneficiario { get; set; }
        public enum tipoAportacion {especie,servicio};
        public string valorMonetarioAproximado { get; set; }
    }
}
