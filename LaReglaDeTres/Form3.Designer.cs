namespace LaReglaDeTres
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.lbProblema = new System.Windows.Forms.Label();
            this.lbSeparador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbSeparador2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBoxSolucion = new System.Windows.Forms.PictureBox();
            this.pictureBoxTorre = new System.Windows.Forms.PictureBox();
            this.pictureBoxDecora = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecora)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teorema de Pitágoras";
            // 
            // lbProblema
            // 
            this.lbProblema.AutoSize = true;
            this.lbProblema.BackColor = System.Drawing.Color.Transparent;
            this.lbProblema.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProblema.Location = new System.Drawing.Point(12, 86);
            this.lbProblema.Name = "lbProblema";
            this.lbProblema.Size = new System.Drawing.Size(361, 85);
            this.lbProblema.TabIndex = 1;
            this.lbProblema.Text = resources.GetString("lbProblema.Text");
            this.lbProblema.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbSeparador
            // 
            this.lbSeparador.AutoSize = true;
            this.lbSeparador.BackColor = System.Drawing.Color.Transparent;
            this.lbSeparador.Location = new System.Drawing.Point(-3, 174);
            this.lbSeparador.Name = "lbSeparador";
            this.lbSeparador.Size = new System.Drawing.Size(715, 13);
            this.lbSeparador.TabIndex = 5;
            this.lbSeparador.Text = "_________________________________________________________________________________" +
    "_____________________________________";
            this.lbSeparador.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Distancia entre el edificio y la escalera\r\n";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistancia.Location = new System.Drawing.Point(64, 278);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.ShortcutsEnabled = false;
            this.txtDistancia.Size = new System.Drawing.Size(100, 22);
            this.txtDistancia.TabIndex = 7;
            this.txtDistancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDistancia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistancia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Metros";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(520, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Longuitud de la escalera";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Metros";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(536, 278);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(219, 445);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(361, 445);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(136, 31);
            this.btnMenu.TabIndex = 13;
            this.btnMenu.Text = "Regresar al menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(549, 444);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbSeparador2
            // 
            this.lbSeparador2.AutoSize = true;
            this.lbSeparador2.BackColor = System.Drawing.Color.Transparent;
            this.lbSeparador2.Location = new System.Drawing.Point(-3, 412);
            this.lbSeparador2.Name = "lbSeparador2";
            this.lbSeparador2.Size = new System.Drawing.Size(715, 13);
            this.lbSeparador2.TabIndex = 15;
            this.lbSeparador2.Text = "_________________________________________________________________________________" +
    "_____________________________________";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(64, 449);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(82, 27);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // pictureBoxSolucion
            // 
            this.pictureBoxSolucion.BackgroundImage = global::LaReglaDeTres.Properties.Resources.marmol;
            this.pictureBoxSolucion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSolucion.Image")));
            this.pictureBoxSolucion.Location = new System.Drawing.Point(257, 219);
            this.pictureBoxSolucion.Name = "pictureBoxSolucion";
            this.pictureBoxSolucion.Size = new System.Drawing.Size(234, 169);
            this.pictureBoxSolucion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSolucion.TabIndex = 16;
            this.pictureBoxSolucion.TabStop = false;
            this.pictureBoxSolucion.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBoxTorre
            // 
            this.pictureBoxTorre.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTorre.Image")));
            this.pictureBoxTorre.Location = new System.Drawing.Point(506, 22);
            this.pictureBoxTorre.Name = "pictureBoxTorre";
            this.pictureBoxTorre.Size = new System.Drawing.Size(160, 149);
            this.pictureBoxTorre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTorre.TabIndex = 3;
            this.pictureBoxTorre.TabStop = false;
            // 
            // pictureBoxDecora
            // 
            this.pictureBoxDecora.Image = global::LaReglaDeTres.Properties.Resources.defini;
            this.pictureBoxDecora.Location = new System.Drawing.Point(34, 12);
            this.pictureBoxDecora.Name = "pictureBoxDecora";
            this.pictureBoxDecora.Size = new System.Drawing.Size(87, 64);
            this.pictureBoxDecora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDecora.TabIndex = 2;
            this.pictureBoxDecora.TabStop = false;
            this.pictureBoxDecora.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form3
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::LaReglaDeTres.Properties.Resources.marmol;
            this.ClientSize = new System.Drawing.Size(687, 510);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pictureBoxSolucion);
            this.Controls.Add(this.lbSeparador2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSeparador);
            this.Controls.Add(this.pictureBoxTorre);
            this.Controls.Add(this.pictureBoxDecora);
            this.Controls.Add(this.lbProblema);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teorema";
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProblema;
        private System.Windows.Forms.PictureBox pictureBoxDecora;
        private System.Windows.Forms.PictureBox pictureBoxTorre;
        private System.Windows.Forms.Label lbSeparador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbSeparador2;
        private System.Windows.Forms.PictureBox pictureBoxSolucion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}