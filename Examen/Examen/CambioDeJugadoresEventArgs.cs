﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class CambioDeJugadoresEventArgs : EventArgs
    {
        public Jugador jugadorViejo { get; set; }
        public Jugador jugadorNuevo { get; set; }
    }
}
