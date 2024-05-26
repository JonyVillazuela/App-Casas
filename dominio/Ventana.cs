using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Ventana
    {
        public int Id { get; set; }
        public string TipoVentana { get; set; }

        public override string ToString()
        {
            return TipoVentana;
        }
    }
}
