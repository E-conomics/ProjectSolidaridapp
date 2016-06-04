using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidaridapp.Org.Solidaridapp.Inicial.Modelo
{
    public class Empresa
    {
        public string nombre { get; set; }
        //Está limitado en BD a 13 caracteres
        public string RFC { get; set; }
        public Usuario usuario { get; set; }
        public string calleNumero { get; set; }
        public string colonia { get; set; }
        public string codigoPostal { get; set; }
        public string nombreRepresentate { get; set; }
        public string estado { get; set; }
        public string municipio { get; set; }
        public string URL { get; set; }
    }
}
