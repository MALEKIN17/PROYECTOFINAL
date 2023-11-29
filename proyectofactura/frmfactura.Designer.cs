namespace proyectofactura
{
    partial class frmfactura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbcedulaempleado = new System.Windows.Forms.Label();
            this.lbnombreempleado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtelefonocliente = new System.Windows.Forms.Label();
            this.lbcedulacliente = new System.Windows.Forms.Label();
            this.lbnombrecliente = new System.Windows.Forms.Label();
            this.lbplacavehiculo = new System.Windows.Forms.Label();
            this.lbmodelovehiculo = new System.Windows.Forms.Label();
            this.lbapellidocliente = new System.Windows.Forms.Label();
            this.lbmarcavehiculo = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbfechafactura = new System.Windows.Forms.Label();
            this.dtgdetalles = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbvalorfactura = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btgenerarpdf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbcodigofactura = new System.Windows.Forms.Label();
            this.btregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdetalles)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectofactura.Properties.Resources.FACTURACION;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbcodigofactura);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbfechafactura);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lbmarcavehiculo);
            this.panel1.Controls.Add(this.lbapellidocliente);
            this.panel1.Controls.Add(this.lbmodelovehiculo);
            this.panel1.Controls.Add(this.lbplacavehiculo);
            this.panel1.Controls.Add(this.lbnombrecliente);
            this.panel1.Controls.Add(this.lbcedulacliente);
            this.panel1.Controls.Add(this.lbtelefonocliente);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbcedulaempleado);
            this.panel1.Controls.Add(this.lbnombreempleado);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 134);
            this.panel1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "MARCA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "PLACA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "MODELO:";
            // 
            // lbcedulaempleado
            // 
            this.lbcedulaempleado.AutoSize = true;
            this.lbcedulaempleado.Location = new System.Drawing.Point(448, 54);
            this.lbcedulaempleado.Name = "lbcedulaempleado";
            this.lbcedulaempleado.Size = new System.Drawing.Size(88, 13);
            this.lbcedulaempleado.TabIndex = 11;
            this.lbcedulaempleado.Text = "cedula empleado";
            // 
            // lbnombreempleado
            // 
            this.lbnombreempleado.AutoSize = true;
            this.lbnombreempleado.Location = new System.Drawing.Point(428, 14);
            this.lbnombreempleado.Name = "lbnombreempleado";
            this.lbnombreempleado.Size = new System.Drawing.Size(44, 13);
            this.lbnombreempleado.TabIndex = 10;
            this.lbnombreempleado.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "CC.EMPLEADO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "EMPLEADO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "APELLIDO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TELEFONO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CC:";
            // 
            // lbtelefonocliente
            // 
            this.lbtelefonocliente.AutoSize = true;
            this.lbtelefonocliente.Location = new System.Drawing.Point(251, 14);
            this.lbtelefonocliente.Name = "lbtelefonocliente";
            this.lbtelefonocliente.Size = new System.Drawing.Size(76, 13);
            this.lbtelefonocliente.TabIndex = 15;
            this.lbtelefonocliente.Text = "telefonocliente";
            // 
            // lbcedulacliente
            // 
            this.lbcedulacliente.AutoSize = true;
            this.lbcedulacliente.Location = new System.Drawing.Point(41, 14);
            this.lbcedulacliente.Name = "lbcedulacliente";
            this.lbcedulacliente.Size = new System.Drawing.Size(70, 13);
            this.lbcedulacliente.TabIndex = 16;
            this.lbcedulacliente.Text = "cedulacliente";
            // 
            // lbnombrecliente
            // 
            this.lbnombrecliente.AutoSize = true;
            this.lbnombrecliente.Location = new System.Drawing.Point(74, 53);
            this.lbnombrecliente.Name = "lbnombrecliente";
            this.lbnombrecliente.Size = new System.Drawing.Size(73, 13);
            this.lbnombrecliente.TabIndex = 17;
            this.lbnombrecliente.Text = "nombrecliente";
            // 
            // lbplacavehiculo
            // 
            this.lbplacavehiculo.AutoSize = true;
            this.lbplacavehiculo.Location = new System.Drawing.Point(61, 92);
            this.lbplacavehiculo.Name = "lbplacavehiculo";
            this.lbplacavehiculo.Size = new System.Drawing.Size(73, 13);
            this.lbplacavehiculo.TabIndex = 18;
            this.lbplacavehiculo.Text = "placavehiculo";
            // 
            // lbmodelovehiculo
            // 
            this.lbmodelovehiculo.AutoSize = true;
            this.lbmodelovehiculo.Location = new System.Drawing.Point(212, 92);
            this.lbmodelovehiculo.Name = "lbmodelovehiculo";
            this.lbmodelovehiculo.Size = new System.Drawing.Size(81, 13);
            this.lbmodelovehiculo.TabIndex = 19;
            this.lbmodelovehiculo.Text = "modelovehiculo";
            // 
            // lbapellidocliente
            // 
            this.lbapellidocliente.AutoSize = true;
            this.lbapellidocliente.Location = new System.Drawing.Point(251, 54);
            this.lbapellidocliente.Name = "lbapellidocliente";
            this.lbapellidocliente.Size = new System.Drawing.Size(74, 13);
            this.lbapellidocliente.TabIndex = 20;
            this.lbapellidocliente.Text = "apellidocliente";
            // 
            // lbmarcavehiculo
            // 
            this.lbmarcavehiculo.AutoSize = true;
            this.lbmarcavehiculo.Location = new System.Drawing.Point(373, 92);
            this.lbmarcavehiculo.Name = "lbmarcavehiculo";
            this.lbmarcavehiculo.Size = new System.Drawing.Size(76, 13);
            this.lbmarcavehiculo.TabIndex = 21;
            this.lbmarcavehiculo.Text = "marcavehiculo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(480, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "FECHA:";
            // 
            // lbfechafactura
            // 
            this.lbfechafactura.AutoSize = true;
            this.lbfechafactura.Location = new System.Drawing.Point(531, 92);
            this.lbfechafactura.Name = "lbfechafactura";
            this.lbfechafactura.Size = new System.Drawing.Size(67, 13);
            this.lbfechafactura.TabIndex = 23;
            this.lbfechafactura.Text = "fechafactura";
            // 
            // dtgdetalles
            // 
            this.dtgdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdetalles.Location = new System.Drawing.Point(160, 185);
            this.dtgdetalles.Name = "dtgdetalles";
            this.dtgdetalles.Size = new System.Drawing.Size(425, 194);
            this.dtgdetalles.TabIndex = 6;
            this.dtgdetalles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdetalles_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lbvalorfactura);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Location = new System.Drawing.Point(175, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 35);
            this.panel2.TabIndex = 9;
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "VALOR TOTAL:";
            // 
            // btgenerarpdf
            // 
            this.btgenerarpdf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btgenerarpdf.Location = new System.Drawing.Point(531, 428);
            this.btgenerarpdf.Name = "btgenerarpdf";
            this.btgenerarpdf.Size = new System.Drawing.Size(104, 35);
            this.btgenerarpdf.TabIndex = 10;
            this.btgenerarpdf.Text = "Generar PDF";
            this.btgenerarpdf.UseVisualStyleBackColor = false;
            this.btgenerarpdf.Click += new System.EventHandler(this.btgenerarpdf_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "CODIGOFACTURA:";
            // 
            // lbcodigofactura
            // 
            this.lbcodigofactura.AutoSize = true;
            this.lbcodigofactura.Location = new System.Drawing.Point(631, 14);
            this.lbcodigofactura.Name = "lbcodigofactura";
            this.lbcodigofactura.Size = new System.Drawing.Size(39, 13);
            this.lbcodigofactura.TabIndex = 25;
            this.lbcodigofactura.Text = "codigo";
            // 
            // btregresar
            // 
            this.btregresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btregresar.Location = new System.Drawing.Point(12, 430);
            this.btregresar.Name = "btregresar";
            this.btregresar.Size = new System.Drawing.Size(104, 35);
            this.btregresar.TabIndex = 11;
            this.btregresar.Text = "Regresar";
            this.btregresar.UseVisualStyleBackColor = false;
            this.btregresar.Click += new System.EventHandler(this.btregresar_Click);
            // 
            // frmfactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 481);
            this.Controls.Add(this.btregresar);
            this.Controls.Add(this.btgenerarpdf);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgdetalles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmfactura";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdetalles)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbcedulaempleado;
        private System.Windows.Forms.Label lbnombreempleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbfechafactura;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbmarcavehiculo;
        private System.Windows.Forms.Label lbapellidocliente;
        private System.Windows.Forms.Label lbmodelovehiculo;
        private System.Windows.Forms.Label lbplacavehiculo;
        private System.Windows.Forms.Label lbnombrecliente;
        private System.Windows.Forms.Label lbcedulacliente;
        private System.Windows.Forms.Label lbtelefonocliente;
        private System.Windows.Forms.DataGridView dtgdetalles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbvalorfactura;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btgenerarpdf;
        private System.Windows.Forms.Label lbcodigofactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btregresar;
    }
}