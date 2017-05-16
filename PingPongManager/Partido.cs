using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongManager
{
    class Partido
    {
        public String Jugador1 { get; set; }
        public String Jugador2 { get; set; }
        public int PuntosJugador1 { get; set; }
        public int PuntosJugador2 { get; set; }

        public Partido(String jug1, String jug2)
        {
            Jugador1 = jug1;
            Jugador2 = jug2;
        }
    }
}