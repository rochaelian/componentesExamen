namespace examen1Componentes
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxJuego = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonComparar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIntentosDisponibles = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelParciales = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelGanador = new System.Windows.Forms.Label();
            this.mensajeGanado = new System.Windows.Forms.Label();
            this.mensajePerdido = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMisIntentos = new System.Windows.Forms.Label();
            this.mensajeParcial = new System.Windows.Forms.Label();
            this.mensajeFallido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar juego";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxJuego
            // 
            this.textBoxJuego.Enabled = false;
            this.textBoxJuego.Location = new System.Drawing.Point(410, 74);
            this.textBoxJuego.Name = "textBoxJuego";
            this.textBoxJuego.Size = new System.Drawing.Size(174, 26);
            this.textBoxJuego.TabIndex = 1;
            this.textBoxJuego.TextChanged += new System.EventHandler(this.textBoxJuego_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese su código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mastermind";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonComparar
            // 
            this.buttonComparar.Enabled = false;
            this.buttonComparar.Location = new System.Drawing.Point(410, 120);
            this.buttonComparar.Name = "buttonComparar";
            this.buttonComparar.Size = new System.Drawing.Size(135, 31);
            this.buttonComparar.TabIndex = 5;
            this.buttonComparar.Text = "Comparar";
            this.buttonComparar.UseVisualStyleBackColor = true;
            this.buttonComparar.Click += new System.EventHandler(this.buttonComparar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Intentos disponibles:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelIntentosDisponibles
            // 
            this.labelIntentosDisponibles.AutoSize = true;
            this.labelIntentosDisponibles.Location = new System.Drawing.Point(598, 302);
            this.labelIntentosDisponibles.Name = "labelIntentosDisponibles";
            this.labelIntentosDisponibles.Size = new System.Drawing.Size(18, 20);
            this.labelIntentosDisponibles.TabIndex = 7;
            this.labelIntentosDisponibles.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Intentos parciales:";
            // 
            // labelParciales
            // 
            this.labelParciales.AutoSize = true;
            this.labelParciales.Location = new System.Drawing.Point(598, 349);
            this.labelParciales.Name = "labelParciales";
            this.labelParciales.Size = new System.Drawing.Size(18, 20);
            this.labelParciales.TabIndex = 9;
            this.labelParciales.Text = "0";
            this.labelParciales.Click += new System.EventHandler(this.labelParciales_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Código mastermind";
            this.label7.Visible = false;
            // 
            // labelGanador
            // 
            this.labelGanador.AutoSize = true;
            this.labelGanador.Location = new System.Drawing.Point(108, 324);
            this.labelGanador.Name = "labelGanador";
            this.labelGanador.Size = new System.Drawing.Size(45, 20);
            this.labelGanador.TabIndex = 11;
            this.labelGanador.Text = "0000";
            this.labelGanador.Visible = false;
            // 
            // mensajeGanado
            // 
            this.mensajeGanado.AutoSize = true;
            this.mensajeGanado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeGanado.Location = new System.Drawing.Point(47, 250);
            this.mensajeGanado.Name = "mensajeGanado";
            this.mensajeGanado.Size = new System.Drawing.Size(175, 20);
            this.mensajeGanado.TabIndex = 12;
            this.mensajeGanado.Text = "¡Ha ganado el juego!";
            this.mensajeGanado.Visible = false;
            // 
            // mensajePerdido
            // 
            this.mensajePerdido.AutoSize = true;
            this.mensajePerdido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajePerdido.Location = new System.Drawing.Point(47, 215);
            this.mensajePerdido.Name = "mensajePerdido";
            this.mensajePerdido.Size = new System.Drawing.Size(191, 20);
            this.mensajePerdido.TabIndex = 13;
            this.mensajePerdido.Text = "¡Ha perdido el juego! :(";
            this.mensajePerdido.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mis intentos";
            // 
            // labelMisIntentos
            // 
            this.labelMisIntentos.AutoSize = true;
            this.labelMisIntentos.Location = new System.Drawing.Point(598, 262);
            this.labelMisIntentos.Name = "labelMisIntentos";
            this.labelMisIntentos.Size = new System.Drawing.Size(18, 20);
            this.labelMisIntentos.TabIndex = 15;
            this.labelMisIntentos.Text = "0";
            this.labelMisIntentos.Click += new System.EventHandler(this.labelMisIntentos_Click);
            // 
            // mensajeParcial
            // 
            this.mensajeParcial.AutoSize = true;
            this.mensajeParcial.Location = new System.Drawing.Point(406, 174);
            this.mensajeParcial.Name = "mensajeParcial";
            this.mensajeParcial.Size = new System.Drawing.Size(192, 20);
            this.mensajeParcial.TabIndex = 16;
            this.mensajeParcial.Text = "Ha acertado parcialmente\r\n";
            this.mensajeParcial.Visible = false;
            this.mensajeParcial.Click += new System.EventHandler(this.mensajeParcial_Click);
            // 
            // mensajeFallido
            // 
            this.mensajeFallido.AutoSize = true;
            this.mensajeFallido.Location = new System.Drawing.Point(410, 214);
            this.mensajeFallido.Name = "mensajeFallido";
            this.mensajeFallido.Size = new System.Drawing.Size(118, 20);
            this.mensajeFallido.TabIndex = 19;
            this.mensajeFallido.Text = "Intento fallido :(";
            this.mensajeFallido.Visible = false;
            this.mensajeFallido.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mensajeFallido);
            this.Controls.Add(this.mensajeParcial);
            this.Controls.Add(this.labelMisIntentos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mensajePerdido);
            this.Controls.Add(this.mensajeGanado);
            this.Controls.Add(this.labelGanador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelParciales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelIntentosDisponibles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonComparar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJuego);
            this.Controls.Add(this.button1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxJuego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonComparar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIntentosDisponibles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelParciales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelGanador;
        private System.Windows.Forms.Label mensajeGanado;
        private System.Windows.Forms.Label mensajePerdido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelMisIntentos;
        private System.Windows.Forms.Label mensajeParcial;
        private System.Windows.Forms.Label mensajeFallido;
    }
}
