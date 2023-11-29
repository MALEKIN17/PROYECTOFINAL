namespace proyectofactura
{
    partial class frmcrearfactura
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btconfirmarcliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbcedulacliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbnombrecliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbapellidocliente = new System.Windows.Forms.TextBox();
            this.tbtelefonocliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbplacavehiculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmodelovehiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbmarcavehiculo = new System.Windows.Forms.TextBox();
            this.btregresar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbcedulaempleado = new System.Windows.Forms.TextBox();
            this.tbnombreempleado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtgservicios = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.tbbuscar = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbvalorfactura = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgservicios)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectofactura.Properties.Resources.cliente;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btconfirmarcliente
            // 
            this.btconfirmarcliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btconfirmarcliente.Location = new System.Drawing.Point(204, 439);
            this.btconfirmarcliente.Name = "btconfirmarcliente";
            this.btconfirmarcliente.Size = new System.Drawing.Size(126, 37);
            this.btconfirmarcliente.TabIndex = 4;
            this.btconfirmarcliente.Text = "Genear Factura";
            this.btconfirmarcliente.UseVisualStyleBackColor = false;
            this.btconfirmarcliente.Click += new System.EventHandler(this.btconfirmarcliente_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbcedulacliente);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbnombrecliente);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbapellidocliente);
            this.panel2.Controls.Add(this.tbtelefonocliente);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 165);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DATOS DEL CLIENTE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "CEDULA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "TELEFONO:";
            // 
            // tbcedulacliente
            // 
            this.tbcedulacliente.Location = new System.Drawing.Point(85, 40);
            this.tbcedulacliente.Name = "tbcedulacliente";
            this.tbcedulacliente.Size = new System.Drawing.Size(119, 20);
            this.tbcedulacliente.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "APELLIDO:";
            // 
            // tbnombrecliente
            // 
            this.tbnombrecliente.Location = new System.Drawing.Point(85, 66);
            this.tbnombrecliente.Name = "tbnombrecliente";
            this.tbnombrecliente.Size = new System.Drawing.Size(119, 20);
            this.tbnombrecliente.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "NOMBRE:";
            // 
            // tbapellidocliente
            // 
            this.tbapellidocliente.Location = new System.Drawing.Point(85, 92);
            this.tbapellidocliente.Name = "tbapellidocliente";
            this.tbapellidocliente.Size = new System.Drawing.Size(119, 20);
            this.tbapellidocliente.TabIndex = 4;
            // 
            // tbtelefonocliente
            // 
            this.tbtelefonocliente.Location = new System.Drawing.Point(85, 118);
            this.tbtelefonocliente.Name = "tbtelefonocliente";
            this.tbtelefonocliente.Size = new System.Drawing.Size(119, 20);
            this.tbtelefonocliente.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbplacavehiculo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbmodelovehiculo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbmarcavehiculo);
            this.panel1.Location = new System.Drawing.Point(234, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 126);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "DATOS DEL VEHICULO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PLACA:";
            // 
            // tbplacavehiculo
            // 
            this.tbplacavehiculo.Location = new System.Drawing.Point(85, 40);
            this.tbplacavehiculo.Name = "tbplacavehiculo";
            this.tbplacavehiculo.Size = new System.Drawing.Size(119, 20);
            this.tbplacavehiculo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "MARCA:";
            // 
            // tbmodelovehiculo
            // 
            this.tbmodelovehiculo.Location = new System.Drawing.Point(85, 66);
            this.tbmodelovehiculo.Name = "tbmodelovehiculo";
            this.tbmodelovehiculo.Size = new System.Drawing.Size(119, 20);
            this.tbmodelovehiculo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MODELO:";
            // 
            // tbmarcavehiculo
            // 
            this.tbmarcavehiculo.Location = new System.Drawing.Point(85, 92);
            this.tbmarcavehiculo.Name = "tbmarcavehiculo";
            this.tbmarcavehiculo.Size = new System.Drawing.Size(119, 20);
            this.tbmarcavehiculo.TabIndex = 4;
            // 
            // btregresar
            // 
            this.btregresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btregresar.Location = new System.Drawing.Point(29, 438);
            this.btregresar.Name = "btregresar";
            this.btregresar.Size = new System.Drawing.Size(85, 37);
            this.btregresar.TabIndex = 12;
            this.btregresar.Text = "Regresar";
            this.btregresar.UseVisualStyleBackColor = false;
            this.btregresar.Click += new System.EventHandler(this.btregresar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tbcedulaempleado);
            this.panel3.Controls.Add(this.tbnombreempleado);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(459, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 98);
            this.panel3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "DATOS DEL EMPLEADO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "CEDULA";
            // 
            // tbcedulaempleado
            // 
            this.tbcedulaempleado.Location = new System.Drawing.Point(85, 40);
            this.tbcedulaempleado.Name = "tbcedulaempleado";
            this.tbcedulaempleado.Size = new System.Drawing.Size(119, 20);
            this.tbcedulaempleado.TabIndex = 2;
            // 
            // tbnombreempleado
            // 
            this.tbnombreempleado.Location = new System.Drawing.Point(85, 66);
            this.tbnombreempleado.Name = "tbnombreempleado";
            this.tbnombreempleado.Size = new System.Drawing.Size(119, 20);
            this.tbnombreempleado.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "NOMBRE";
            // 
            // dtgservicios
            // 
            this.dtgservicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgservicios.Location = new System.Drawing.Point(139, 218);
            this.dtgservicios.Name = "dtgservicios";
            this.dtgservicios.Size = new System.Drawing.Size(422, 193);
            this.dtgservicios.TabIndex = 13;
            this.dtgservicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgservicios_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(398, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Buscar ";
            // 
            // tbbuscar
            // 
            this.tbbuscar.Location = new System.Drawing.Point(464, 192);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.Size = new System.Drawing.Size(199, 20);
            this.tbbuscar.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.lbvalorfactura);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(464, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 39);
            this.panel4.TabIndex = 17;
            // 
            // lbvalorfactura
            // 
            this.lbvalorfactura.AutoSize = true;
            this.lbvalorfactura.Location = new System.Drawing.Point(104, 13);
            this.lbvalorfactura.Name = "lbvalorfactura";
            this.lbvalorfactura.Size = new System.Drawing.Size(33, 13);
            this.lbvalorfactura.TabIndex = 5;
            this.lbvalorfactura.Text = "valor ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "VALOR TOTAL:";
            // 
            // frmregistrocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 509);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tbbuscar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtgservicios);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btregresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btconfirmarcliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmregistrocliente";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgservicios)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btconfirmarcliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbcedulacliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbnombrecliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbapellidocliente;
        private System.Windows.Forms.TextBox tbtelefonocliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbplacavehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmodelovehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbmarcavehiculo;
        private System.Windows.Forms.Button btregresar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbcedulaempleado;
        private System.Windows.Forms.TextBox tbnombreempleado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dtgservicios;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbbuscar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbvalorfactura;
        private System.Windows.Forms.Label label12;
    }
}