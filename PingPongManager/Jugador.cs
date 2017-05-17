using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongManager
{
    public class Jugador
    {
        public String Id { get; set; }
        public String Nombre { get; set; }
        public String Image { get; set; }
        public int Jugados { get; set; }
        public int Puntos { get; set; }

        public Jugador(String nombre, String image = null)
        {
            Nombre = nombre;
            Image = image;
        }

        public override string ToString()
        {
            return Nombre + " - " + Id;
        }

        public int getPuntos()
        {
            return this.Puntos;
        }

        public int getJugados()
        {
            return this.Jugados;
        }

        public int getPartidosPorDos()
        {
            int multiplicador = 2;
            int resultado = multiplicador * this.Jugados;

            return resultado;
        }

        public int getPuntuacion()
        {
            int puntuacion;

            return puntuacion = this.Jugados * 3;
        }

        public void setPuntos(int puntos)
        {
            this.Puntos = puntos;
        }

        public void setJugados(int jugados)
        {
            this.Jugados = jugados;
        }
    }
}
