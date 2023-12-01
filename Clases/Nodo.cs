using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_azb_R.Clases
{
    class Nodo
    {
        public Carros Datos { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Carros datos)
        {
            Datos = datos;
            Siguiente = null;
        }
    }
}
