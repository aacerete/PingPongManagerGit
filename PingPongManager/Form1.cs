using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongManager
{
    public partial class Form1 : Form
    {

        private bool AñadirPlayer = false;

        public Form1()
        {
            InitializeComponent();

            desactivaPanelJugador();
            desactivaBotonesJugador();
            btnAñadirPlayer.Enabled = true;
            

        }

        private void btnAñadirPlayer_Click(object sender, EventArgs e)
        {
            activaPanelJugador();
        }

        private void desactivaPanelJugador()
        {
            desactivaGuardarRegistroJugador();
            desactivaBotonesJugador();
            btnImagen.Enabled = false;
            txNombreJugador.Enabled = false;
        }

        private void activaPanelJugador()
        {
            activaGuardarRegistroJugador();
            desactivaBotonesJugador();
            btnImagen.Enabled = true;
            txNombreJugador.Enabled = true;
            
        }



        private void activaGuardarRegistroJugador()
        {
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
 
        }
        private void desactivaGuardarRegistroJugador()
        {
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            activaGuardarRegistroJugador();
          //  enableBtJugador();
           // btImg.Enabled = false;
            //tbNombreJ.Enabled = false;
            //addPlayer = false;
        }

        private void activaBotonesJugador()
        {
            btnAñadirPlayer.Enabled = true;
            btnModificarPlayer.Enabled = true;
            btnEliminarPlayer.Enabled = true;
        }

        private void desactivaBotonesJugador()
        {
            btnAñadirPlayer.Enabled = false;
            btnModificarPlayer.Enabled = false;
            btnEliminarPlayer.Enabled = false;
            
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {

        }

    }
}