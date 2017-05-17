namespace PingPongManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dialogImagen = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Jugadores = new System.Windows.Forms.TabPage();
            this.btnAñadirPlayer = new System.Windows.Forms.Button();
            this.btnEliminarPlayer = new System.Windows.Forms.Button();
            this.PanelJugadores = new System.Windows.Forms.Panel();
            this.btnImagen = new System.Windows.Forms.Button();
            this.txNombreJugador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblListaJugadores = new System.Windows.Forms.Label();
            this.btnModificarPlayer = new System.Windows.Forms.Button();
            this.lvJugadores = new System.Windows.Forms.ListView();
            this.Competicion = new System.Windows.Forms.TabPage();
            this.panelCompeticion = new System.Windows.Forms.Panel();
            this.btnGuardarResultado = new System.Windows.Forms.Button();
            this.txbResultP2 = new System.Windows.Forms.TextBox();
            this.txbResultP1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbJugador2Later = new System.Windows.Forms.TextBox();
            this.txbJugador1Later = new System.Windows.Forms.TextBox();
            this.txbJudador2Now = new System.Windows.Forms.TextBox();
            this.txbJudador1Now = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.btnCancelarCompeticion = new System.Windows.Forms.Button();
            this.btnNuevaCompeticion = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Jugadores.SuspendLayout();
            this.PanelJugadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Competicion.SuspendLayout();
            this.panelCompeticion.SuspendLayout();
            this.SuspendLayout();

            //
            // dialogImagen
            //

            this.dialogImagen.FileName = "dialogImagen";
            this.dialogImagen.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.dialogImagen.Title = "Elije una imagen";


            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Jugadores);
            this.tabControl1.Controls.Add(this.Competicion);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // Jugadores
            // 
            this.Jugadores.Controls.Add(this.btnAñadirPlayer);
            this.Jugadores.Controls.Add(this.btnEliminarPlayer);
            this.Jugadores.Controls.Add(this.PanelJugadores);
            this.Jugadores.Controls.Add(this.lblListaJugadores);
            this.Jugadores.Controls.Add(this.btnModificarPlayer);
            this.Jugadores.Controls.Add(this.lvJugadores);
            this.Jugadores.Location = new System.Drawing.Point(4, 22);
            this.Jugadores.Name = "Jugadores";
            this.Jugadores.Padding = new System.Windows.Forms.Padding(3);
            this.Jugadores.Size = new System.Drawing.Size(747, 370);
            this.Jugadores.TabIndex = 0;
            this.Jugadores.Text = "Gestion de jugadores";
            this.Jugadores.UseVisualStyleBackColor = true;
            // 
            // btnAñadirPlayer
            // 
            this.btnAñadirPlayer.Location = new System.Drawing.Point(11, 261);
            this.btnAñadirPlayer.Name = "btnAñadirPlayer";
            this.btnAñadirPlayer.Size = new System.Drawing.Size(166, 25);
            this.btnAñadirPlayer.TabIndex = 6;
            this.btnAñadirPlayer.Text = "Añadir nuevo";
            this.btnAñadirPlayer.UseVisualStyleBackColor = true;
            this.btnAñadirPlayer.Click += new System.EventHandler(this.btnAñadirPlayer_Click);
            // 
            // btnEliminarPlayer
            // 
            this.btnEliminarPlayer.Location = new System.Drawing.Point(11, 325);
            this.btnEliminarPlayer.Name = "btnEliminarPlayer";
            this.btnEliminarPlayer.Size = new System.Drawing.Size(166, 25);
            this.btnEliminarPlayer.TabIndex = 5;
            this.btnEliminarPlayer.Text = "Eliminar seleccionado";
            this.btnEliminarPlayer.UseVisualStyleBackColor = true;
            // 
            // PanelJugadores
            // 
            this.PanelJugadores.Controls.Add(this.btnCancelar);
            this.PanelJugadores.Controls.Add(this.btnGuardar);
            this.PanelJugadores.Controls.Add(this.btnImagen);
            this.PanelJugadores.Controls.Add(this.txNombreJugador);
            this.PanelJugadores.Controls.Add(this.label2);
            this.PanelJugadores.Controls.Add(this.pictureBox1);
            this.PanelJugadores.Location = new System.Drawing.Point(197, 43);
            this.PanelJugadores.Name = "PanelJugadores";
            this.PanelJugadores.Size = new System.Drawing.Size(531, 307);
            this.PanelJugadores.TabIndex = 4;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(17, 251);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(137, 23);
            this.btnImagen.TabIndex = 3;
            this.btnImagen.Text = "Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // txNombreJugador
            // 
            this.txNombreJugador.Location = new System.Drawing.Point(70, 15);
            this.txNombreJugador.Name = "txNombreJugador";
            this.txNombreJugador.Size = new System.Drawing.Size(431, 20);
            this.txNombreJugador.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 187);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblListaJugadores
            // 
            this.lblListaJugadores.AutoSize = true;
            this.lblListaJugadores.Location = new System.Drawing.Point(8, 14);
            this.lblListaJugadores.Name = "lblListaJugadores";
            this.lblListaJugadores.Size = new System.Drawing.Size(93, 13);
            this.lblListaJugadores.TabIndex = 3;
            this.lblListaJugadores.Text = "Lista de jugadores";

            // 
            // btnModificarPlayer
            // 
            this.btnModificarPlayer.Location = new System.Drawing.Point(11, 292);
            this.btnModificarPlayer.Name = "btnModificarPlayer";
            this.btnModificarPlayer.Size = new System.Drawing.Size(166, 25);
            this.btnModificarPlayer.TabIndex = 2;
            this.btnModificarPlayer.Text = "Modificar seleccionado";
            this.btnModificarPlayer.UseVisualStyleBackColor = true;
            // 
            // lvJugadores
            // 
            this.lvJugadores.Location = new System.Drawing.Point(9, 43);
            this.lvJugadores.Name = "lvJugadores";
            this.lvJugadores.Size = new System.Drawing.Size(168, 212);
            this.lvJugadores.TabIndex = 0;
            this.lvJugadores.UseCompatibleStateImageBehavior = false;
            this.lvJugadores.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvJugadores.ItemActivate += new System.EventHandler(this.lvJugadores_ItemActivate);


            // 
            // Competicion
            // 
            this.Competicion.Controls.Add(this.panelCompeticion);
            this.Competicion.Controls.Add(this.btnCancelarCompeticion);
            this.Competicion.Controls.Add(this.btnNuevaCompeticion);
            this.Competicion.Controls.Add(this.listView2);
            this.Competicion.Controls.Add(this.label3);
            this.Competicion.Location = new System.Drawing.Point(4, 22);
            this.Competicion.Name = "Competicion";
            this.Competicion.Padding = new System.Windows.Forms.Padding(3);
            this.Competicion.Size = new System.Drawing.Size(747, 370);
            this.Competicion.TabIndex = 1;
            this.Competicion.Text = "Gestor de competiciones";
            this.Competicion.UseVisualStyleBackColor = true;
            // 
            // panelCompeticion
            // 
            this.panelCompeticion.Controls.Add(this.btnGuardarResultado);
            this.panelCompeticion.Controls.Add(this.txbResultP2);
            this.panelCompeticion.Controls.Add(this.txbResultP1);
            this.panelCompeticion.Controls.Add(this.label7);
            this.panelCompeticion.Controls.Add(this.txbJugador2Later);
            this.panelCompeticion.Controls.Add(this.txbJugador1Later);
            this.panelCompeticion.Controls.Add(this.txbJudador2Now);
            this.panelCompeticion.Controls.Add(this.txbJudador1Now);
            this.panelCompeticion.Controls.Add(this.label6);
            this.panelCompeticion.Controls.Add(this.label5);
            this.panelCompeticion.Controls.Add(this.listView3);
            this.panelCompeticion.Controls.Add(this.lblClasificacion);
            this.panelCompeticion.Location = new System.Drawing.Point(196, 42);
            this.panelCompeticion.Name = "panelCompeticion";
            this.panelCompeticion.Size = new System.Drawing.Size(527, 312);
            this.panelCompeticion.TabIndex = 4;
            // 
            // btnGuardarResultado
            // 
            this.btnGuardarResultado.Location = new System.Drawing.Point(170, 123);
            this.btnGuardarResultado.Name = "btnGuardarResultado";
            this.btnGuardarResultado.Size = new System.Drawing.Size(319, 23);
            this.btnGuardarResultado.TabIndex = 11;
            this.btnGuardarResultado.Text = "Guardar Resultado";
            this.btnGuardarResultado.UseVisualStyleBackColor = true;
            // 
            // txbResultP2
            // 
            this.txbResultP2.Location = new System.Drawing.Point(437, 96);
            this.txbResultP2.Name = "txbResultP2";
            this.txbResultP2.Size = new System.Drawing.Size(52, 20);
            this.txbResultP2.TabIndex = 10;
            // 
            // txbResultP1
            // 
            this.txbResultP1.Location = new System.Drawing.Point(437, 68);
            this.txbResultP1.Name = "txbResultP1";
            this.txbResultP1.Size = new System.Drawing.Size(52, 20);
            this.txbResultP1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Resultado";
            // 
            // txbJugador2Later
            // 
            this.txbJugador2Later.Location = new System.Drawing.Point(170, 234);
            this.txbJugador2Later.Name = "txbJugador2Later";
            this.txbJugador2Later.Size = new System.Drawing.Size(226, 20);
            this.txbJugador2Later.TabIndex = 7;
            // 
            // txbJugador1Later
            // 
            this.txbJugador1Later.Location = new System.Drawing.Point(170, 207);
            this.txbJugador1Later.Name = "txbJugador1Later";
            this.txbJugador1Later.Size = new System.Drawing.Size(226, 20);
            this.txbJugador1Later.TabIndex = 6;
            // 
            // txbJudador2Now
            // 
            this.txbJudador2Now.Location = new System.Drawing.Point(170, 96);
            this.txbJudador2Now.Name = "txbJudador2Now";
            this.txbJudador2Now.Size = new System.Drawing.Size(226, 20);
            this.txbJudador2Now.TabIndex = 5;
            // 
            // txbJudador1Now
            // 
            this.txbJudador1Now.Location = new System.Drawing.Point(170, 69);
            this.txbJudador1Now.Name = "txbJudador1Now";
            this.txbJudador1Now.Size = new System.Drawing.Size(226, 20);
            this.txbJudador1Now.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Proximo partido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Partido actual";
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(17, 42);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(134, 252);
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(14, 15);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(98, 13);
            this.lblClasificacion.TabIndex = 0;
            this.lblClasificacion.Text = "Clasificacion actual";

            // 
            // btnCancelarCompeticion
            // 
            this.btnCancelarCompeticion.Location = new System.Drawing.Point(11, 322);
            this.btnCancelarCompeticion.Name = "btnCancelarCompeticion";
            this.btnCancelarCompeticion.Size = new System.Drawing.Size(165, 32);
            this.btnCancelarCompeticion.TabIndex = 3;
            this.btnCancelarCompeticion.Text = "Cancelar competicion";
            this.btnCancelarCompeticion.UseVisualStyleBackColor = true;
            // 
            // btnNuevaCompeticion
            // 
            this.btnNuevaCompeticion.Location = new System.Drawing.Point(11, 285);
            this.btnNuevaCompeticion.Name = "btnNuevaCompeticion";
            this.btnNuevaCompeticion.Size = new System.Drawing.Size(165, 31);
            this.btnNuevaCompeticion.TabIndex = 2;
            this.btnNuevaCompeticion.Text = "Nueva Competicion";
            this.btnNuevaCompeticion.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(11, 42);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(165, 237);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lista de competiciones";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(440, 251);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(350, 251);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 624);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gestor de ligas";
            this.tabControl1.ResumeLayout(false);
            this.Jugadores.ResumeLayout(false);
            this.Jugadores.PerformLayout();
            this.PanelJugadores.ResumeLayout(false);
            this.PanelJugadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Competicion.ResumeLayout(false);
            this.Competicion.PerformLayout();
            this.panelCompeticion.ResumeLayout(false);
            this.panelCompeticion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Jugadores;
        private System.Windows.Forms.TabPage Competicion;
        private System.Windows.Forms.Button btnModificarPlayer;
        private System.Windows.Forms.ListView lvJugadores;
        private System.Windows.Forms.Label lblListaJugadores;
        private System.Windows.Forms.Button btnEliminarPlayer;
        private System.Windows.Forms.Panel PanelJugadores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAñadirPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.TextBox txNombreJugador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevaCompeticion;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnCancelarCompeticion;
        private System.Windows.Forms.Panel panelCompeticion;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbJudador2Now;
        private System.Windows.Forms.TextBox txbJudador1Now;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbJugador2Later;
        private System.Windows.Forms.TextBox txbJugador1Later;
        private System.Windows.Forms.TextBox txbResultP2;
        private System.Windows.Forms.TextBox txbResultP1;
        private System.Windows.Forms.Button btnGuardarResultado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.OpenFileDialog dialogImagen;
    }
}

