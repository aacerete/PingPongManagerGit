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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Jugadores = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Competicion = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Jugadores.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Competicion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.Jugadores.Controls.Add(this.button3);
            this.Jugadores.Controls.Add(this.button1);
            this.Jugadores.Controls.Add(this.panel1);
            this.Jugadores.Controls.Add(this.label1);
            this.Jugadores.Controls.Add(this.button2);
            this.Jugadores.Controls.Add(this.listView1);
            this.Jugadores.Location = new System.Drawing.Point(4, 22);
            this.Jugadores.Name = "Jugadores";
            this.Jugadores.Padding = new System.Windows.Forms.Padding(3);
            this.Jugadores.Size = new System.Drawing.Size(747, 370);
            this.Jugadores.TabIndex = 0;
            this.Jugadores.Text = "Gestion de jugadores";
            this.Jugadores.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "Añadir nuevo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Eliminar seleccionado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(197, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 307);
            this.panel1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Imagen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 20);
            this.textBox1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de jugadores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar seleccionado";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(9, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(168, 212);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Competicion
            // 
            this.Competicion.Controls.Add(this.panel2);
            this.Competicion.Controls.Add(this.button6);
            this.Competicion.Controls.Add(this.button5);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.listView3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(196, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 312);
            this.panel2.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(170, 123);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(319, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Guardar Resultado";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(437, 96);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(52, 20);
            this.textBox7.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(437, 68);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(52, 20);
            this.textBox6.TabIndex = 9;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(170, 234);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(226, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(170, 207);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(170, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 20);
            this.textBox2.TabIndex = 4;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Clasificacion actual";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 322);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 32);
            this.button6.TabIndex = 3;
            this.button6.Text = "Cancelar competicion";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 31);
            this.button5.TabIndex = 2;
            this.button5.Text = "Nueva Competicion";
            this.button5.UseVisualStyleBackColor = true;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Competicion.ResumeLayout(false);
            this.Competicion.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Jugadores;
        private System.Windows.Forms.TabPage Competicion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button7;
    }
}

