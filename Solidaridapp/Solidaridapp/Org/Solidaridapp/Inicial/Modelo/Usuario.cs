using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidaridapp.Org.Solidaridapp.Inicial.Modelo
{
    public class Usuario
    {
        public string correo { get; set; }
        //Está limitado en BD a 10 dígitos
        public string telefono { get; set; }
        //En BD está limitada a 20 caracteres
        public string clave { get; set; }
    }
}
