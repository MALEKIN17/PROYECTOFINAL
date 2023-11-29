namespace proyectofactura
{
    partial class frmempleado
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btborrarcliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            this.tbbuscarusuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btcrearfactura = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbusuarioempleado = new System.Windows.Forms.Label();
            this.lbrol = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbtelefonoempleado = new System.Windows.Forms.Label();
            this.lbcedulaempleado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btsalir = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.btborrarcliente);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dgvclientes);
            this.panel2.Controls.Add(this.tbbuscarusuario);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btcrearfactura);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(169, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 393);
            this.panel2.TabIndex = 0;
            // 
            // btborrarcliente
            // 
            this.btborrarcliente.BackColor = System.Drawing.Color.Green;
            this.btborrarcliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btborrarcliente.Location = new System.Drawing.Point(253, 65);
            this.btborrarcliente.Name = "btborrarcliente";
            this.btborrarcliente.Size = new System.Drawing.Size(106, 32);
            this.btborrarcliente.TabIndex = 6;
            this.btborrarcliente.Text = "Borrar Cliente";
            this.btborrarcliente.UseVisualStyleBackColor = false;
            this.btborrarcliente.Click += new System.EventHandler(this.btborrarcliente_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(126, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crear Factura";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvclientes
            // 
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Location = new System.Drawing.Point(62, 136);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvclientes.Size = new System.Drawing.Size(493, 226);
            this.dgvclientes.TabIndex = 4;
            this.dgvclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclientes_CellClick);
            this.dgvclientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclientes_CellDoubleClick);
            this.dgvclientes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclientes_CellEndEdit);
            // 
            // tbbuscarusuario
            // 
            this.tbbuscarusuario.Location = new System.Drawing.Point(392, 65);
            this.tbbuscarusuario.Name = "tbbuscarusuario";
            this.tbbuscarusuario.Size = new System.Drawing.Size(227, 20);
            this.tbbuscarusuario.TabIndex = 3;
            this.tbbuscarusuario.TextChanged += new System.EventHandler(this.tbbuscarusuario_TextChanged);
            this.tbbuscarusuario.Enter += new System.EventHandler(this.tbbuscarusuario_Enter);
            this.tbbuscarusuario.Leave += new System.EventHandler(this.tbbuscarusuario_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(389, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Buscar Usuario";
            // 
            // btcrearfactura
            // 
            this.btcrearfactura.BackColor = System.Drawing.Color.Green;
            this.btcrearfactura.ForeColor = System.Drawing.SystemColors.Control;
            this.btcrearfactura.Location = new System.Drawing.Point(3, 65);
            this.btcrearfactura.Name = "btcrearfactura";
            this.btcrearfactura.Size = new System.Drawing.Size(106, 32);
            this.btcrearfactura.TabIndex = 1;
            this.btcrearfactura.Text = "Registar cliente";
            this.btcrearfactura.UseVisualStyleBackColor = false;
            this.btcrearfactura.Click += new System.EventHandler(this.btcrearfactura_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "USUARIOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE FACTURACION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbusuarioempleado
            // 
            this.lbusuarioempleado.AutoSize = true;
            this.lbusuarioempleado.ForeColor = System.Drawing.SystemColors.Control;
            this.lbusuarioempleado.Location = new System.Drawing.Point(98, 84);
            this.lbusuarioempleado.Name = "lbusuarioempleado";
            this.lbusuarioempleado.Size = new System.Drawing.Size(42, 13);
            this.lbusuarioempleado.TabIndex = 2;
            this.lbusuarioempleado.Text = "nombre";
            // 
            // lbrol
            // 
            this.lbrol.AutoSize = true;
            this.lbrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrol.ForeColor = System.Drawing.SystemColors.Control;
            this.lbrol.Location = new System.Drawing.Point(68, 204);
            this.lbrol.Name = "lbrol";
            this.lbrol.Size = new System.Drawing.Size(32, 13);
            this.lbrol.TabIndex = 3;
            this.lbrol.Text = "ROL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lbtelefonoempleado);
            this.panel1.Controls.Add(this.lbcedulaempleado);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbrol);
            this.panel1.Controls.Add(this.lbusuarioempleado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 450);
            this.panel1.TabIndex = 0;
            // 
            // lbtelefonoempleado
            // 
            this.lbtelefonoempleado.AutoSize = true;
            this.lbtelefonoempleado.ForeColor = System.Drawing.SystemColors.Control;
            this.lbtelefonoempleado.Location = new System.Drawing.Point(103, 150);
            this.lbtelefonoempleado.Name = "lbtelefonoempleado";
            this.lbtelefonoempleado.Size = new System.Drawing.Size(45, 13);
            this.lbtelefonoempleado.TabIndex = 12;
            this.lbtelefonoempleado.Text = "telefono";
            // 
            // lbcedulaempleado
            // 
            this.lbcedulaempleado.AutoSize = true;
            this.lbcedulaempleado.ForeColor = System.Drawing.SystemColors.Control;
            this.lbcedulaempleado.Location = new System.Drawing.Point(101, 119);
            this.lbcedulaempleado.Name = "lbcedulaempleado";
            this.lbcedulaempleado.Size = new System.Drawing.Size(39, 13);
            this.lbcedulaempleado.TabIndex = 11;
            this.lbcedulaempleado.Text = "cedula";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(11, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "TELEFONO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(12, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "CEDULA:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btsalir);
            this.panel3.Location = new System.Drawing.Point(3, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 191);
            this.panel3.TabIndex = 3;
            // 
            // btsalir
            // 
            this.btsalir.BackColor = System.Drawing.Color.Green;
            this.btsalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btsalir.Location = new System.Drawing.Point(11, 128);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(134, 32);
            this.btsalir.TabIndex = 2;
            this.btsalir.Text = "Cerrar Sesion";
            this.btsalir.UseVisualStyleBackColor = false;
            this.btsalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmempleado";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btcrearfactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbusuarioempleado;
        private System.Windows.Forms.Label lbrol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvclientes;
        private System.Windows.Forms.TextBox tbbuscarusuario;
        private System.Windows.Forms.Label lbtelefonoempleado;
        private System.Windows.Forms.Label lbcedulaempleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btborrarcliente;
    }
}