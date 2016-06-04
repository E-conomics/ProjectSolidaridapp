using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidaridapp.Org.Solidaridapp.Inicial.Modelo
{
    public class Beneficiario
    {
        public Usuario usuario { get; set; }
        public int numeroBeneficiarios { get; set; }
        //En BD hay una tabla llamada Giro, para relacionar el ID con su descripción para hacer más fácil la escalabilidad. Aquí no le encontré mucho sentido agregar otra clase solo para eso, así que se puede agregar solo como un string (: 
        public string giro { get; set; }
    }
}
