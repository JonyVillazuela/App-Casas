using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Vivienda
    {
        public int Id { get; set; }

        [DisplayName("Casa/lote")]
        public int Casa_lote { get; set; }
        public int Ambientes { get; set; }
        public int M2  { get; set; }
        public string Imagen { get; set; }

        public int Dormitorios { get; set; }

        public int Baños { get; set; }

        public string Piscina { get; set; }

        [DisplayName("Tipo de Ventana")]
        public Ventana Tipo_de_Ventana { get; set; }

        [DisplayName("Tipo de Calefacción")]
        public Calefaccion Tipo_de_Calefaccion { get; set; }

        public Vivienda()
        {
            Tipo_de_Ventana = new Ventana(); 
            Tipo_de_Calefaccion = new Calefaccion(); 
        }
    }
}
