using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;


namespace PingPongManager
{
    public partial class Form1 : Form
    {

        private bool AñadirPlayer = false;
        private Jugador jugador;
        private List<Jugador> jugadores = new List<Jugador>();
        private String imagen;
        


        public Form1()
        {
            InitializeComponent();
            desactivaPanelJugador();
            desactivaBotonesJugador();
            btnAñadirPlayer.Enabled = true;
            getFromFireBaseJugador();


        }

        private void btnAñadirPlayer_Click(object sender, EventArgs e)
        {
            activaPanelJugador();

        }

        private void desactivaPanelJugador()
        {
            AñadirPlayer = false;
            desactivaGuardarRegistroJugador();
            desactivaBotonesJugador();
            btnImagen.Enabled = false;
            txNombreJugador.Enabled = false;
        }

        private void activaPanelJugador()
        {
            AñadirPlayer = true;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivaPanelJugador();
            activaBotonesJugador();
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
            if (dialogImagen.ShowDialog() == DialogResult.OK)
            {
                imagen = dialogImagen.FileName;
                pictureBox1.Load(dialogImagen.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txNombreJugador.Text))
            {
                MessageBox.Show("Introduce un nombre para continuar");
            }
            else if (string.IsNullOrEmpty(imagen))
            {
                MessageBox.Show("Introduce una imagen para continuar");
            }
            else
            {
                jugador = new Jugador(txNombreJugador.Text, imagen);
                //jugadores.Add(jugador);
                setToFireBaseJugador();

                MessageBox.Show("Jugador guardado en la BBDD");

                actualizaListViewJugadores();

                desactivaPanelJugador();
                activaBotonesJugador();
            }
        }

        private void reiniciaListViewJugadores()
        {
            this.lvJugadores.Items.Clear();
            this.lvJugadores.Update();
            this.lvJugadores.Refresh();
            this.lvJugadores.View = View.List;
        }

        private void actualizaListViewJugadores()
        {
            reiniciaListViewJugadores();
            for (int i = 0; i < jugadores.Count; i++)
            {
                lvJugadores.Items.Add(jugadores[i].Nombre);
            }
        }

        private void lvJugadores_ItemActivate(object sender, EventArgs e)
        {

            int i = lvJugadores.SelectedIndices[0];
            Jugador j = jugadores[i];
            txNombreJugador.Text = j.Nombre;
        }


        private async Task setToFireBaseJugador()
        {
            var client = new FirebaseClient("https://pingpongmanager-cf07a.firebaseio.com/");
            var child = client.Child("jugadores/");

            var jugador1 = await child.PostAsync(jugador);
            jugador.Id = jugador1.Key;
                       
        }

        private async Task getFromFireBaseJugador()
        {
            var firebase = new FirebaseClient("https://pingpongmanager-cf07a.firebaseio.com/");
            var ListajugadoresFireBase = await firebase.Child("jugadores").OnceAsync<Jugador>();
                        
            foreach (var jugador1 in ListajugadoresFireBase)
            {
                Jugador j = jugador1.Object;
                this.jugadores.Add(j);
            }

            lvJugadores.View = View.List;

            for (int i = 0; i < jugadores.Count; i++)
            {
                lvJugadores.Items.Add(jugadores[i].Nombre);
            }
        }

    }
}