﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Calefaccion
    {
        public int Id { get; set; }
        public string TipoCalefaccion { get; set; }

        public override string ToString()
        {
            return TipoCalefaccion;
        }
    }
}
