﻿using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongManager
{
    class Jugador
    {
        public String Id { get; set; }
        public String Nombre { get; set; }
        public String Image { get; set; }
        public int Jugados { get; set; }
        public int Puntos { get; set; }

        public Jugador(String nombre, String image)
        {
            Nombre = nombre;
            Image = image;
        }

        public override string ToString()
        {
            return Nombre + " - " + Id;
        }
    }
}