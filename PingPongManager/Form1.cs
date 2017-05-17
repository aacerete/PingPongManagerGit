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

        private Jugador jugador;
        private List<Jugador> jugadores = new List<Jugador>();
        private String imagen;
        private Boolean añadiendo;
        private Boolean modificando;
        private Boolean eliminando;
        private int posJugador;



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
            clearRegistros();
            activaPanelJugador();
            añadiendo = true;

        }

        private void btnModificarPlayer_Click(object sender, EventArgs e)
        {
            activaPanelJugador();
            activaGuardarRegistroJugador();
            modificando = true;
            
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivaPanelJugador();
            activaBotonesJugador();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            if (dialogImagen.ShowDialog() == DialogResult.OK)
            {
                imagen = dialogImagen.FileName;
                pictureBox1.Load(dialogImagen.FileName);
            }
        }

        private void btnEliminarPlayer_Click(object sender, EventArgs e)
        {
            deleteFromFireBaseJugador(jugadores[lvJugadores.SelectedIndices[0]]);
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



        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (añadiendo)
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
                    setToFireBaseJugador(jugador);

                    MessageBox.Show("Jugador guardado en la BBDD");


                    desactivaPanelJugador();
                    activaBotonesJugador();
                }
                clearRegistros();
                getFromFireBaseJugador();
                añadiendo = false;
            }

            if (modificando)
            {

                jugadores[posJugador].Nombre = txNombreJugador.Text;
                updateToFireBaseJugador(jugadores[posJugador]);
                desactivaPanelJugador();
                activaBotonesJugador();
                clearRegistros();

                modificando = false;
            }


                       
            
        }

        private void reiniciaListViewJugadores()
        {
            this.jugadores = new List<Jugador>();
            this.lvJugadores.Items.Clear();
            this.lvJugadores.Update();
            this.lvJugadores.Refresh();
        }

        private void lvJugadores_ItemActivate(object sender, EventArgs e)
        {

            int i = lvJugadores.SelectedIndices[0];
            Jugador j = jugadores[i];
            txNombreJugador.Text = j.Nombre;
            pictureBox1.Load(j.Image);

            activaBotonesJugador();

        }


        private async Task setToFireBaseJugador(Jugador jugador)
        {
            var client = new FirebaseClient("https://pingpongmanager-cf07a.firebaseio.com/");
            var child = client.Child("jugadores");

            var jugador1 = await child.PostAsync(jugador);
          
                       
        }

        private async Task getFromFireBaseJugador()
        {
            reiniciaListViewJugadores();
            var firebase = new FirebaseClient("https://pingpongmanager-cf07a.firebaseio.com/");
            var ListajugadoresFireBase = await firebase.Child("jugadores").OnceAsync<Jugador>();
                        
            foreach (var jugador1 in ListajugadoresFireBase)
            {
                Jugador j = jugador1.Object;
                j.Id = jugador1.Key;
                this.jugadores.Add(j);
            }

            lvJugadores.View = View.List;

            for (int i = 0; i < jugadores.Count; i++)
            {
                lvJugadores.Items.Add(jugadores[i].Nombre);
            }

        }

        private async Task deleteFromFireBaseJugador(Jugador jugador)
        {
            var client = new FirebaseClient("https://pingpongmanager-cf07a.firebaseio.com/");
            var child = client.Child("jugadores/" + jugador.Id);
            await child.DeleteAsync();

            MessageBox.Show("Jugador eliminado de la BBDD");

            clearRegistros();
            getFromFireBaseJugador();
        }

        private async Task updateToFireBaseJugador(Jugador jugador)
        {
            var client = new FirebaseClient("https://pingpongmanager-cf07a.firebaseio.com/");
            var child = client.Child("jugadores/" + jugador.Id);

            await child.PutAsync(jugador);

            MessageBox.Show("Jugador actualizado en la BBDD");
            clearRegistros();
            getFromFireBaseJugador();
        }

        private void clearRegistros()
        {
            txNombreJugador.Clear();
            pictureBox1.Image = null;
        }

    }
}