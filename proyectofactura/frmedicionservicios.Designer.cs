namespace proyectofactura
{
    partial class frmedicionservicios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbtelefonopropietario = new System.Windows.Forms.Label();
            this.lbcedulapropietario = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btsalir = new System.Windows.Forms.Button();
            this.btgestionempleados = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbusuariopropietario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btborrarservicio = new System.Windows.Forms.Button();
            this.dgvservicios = new System.Windows.Forms.DataGridView();
            this.tbbuscarservicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btcrearservicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvservicios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lbtelefonopropietario);
            this.panel1.Controls.Add(this.lbcedulapropietario);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbusuariopropietario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 450);
            this.panel1.TabIndex = 2;
            // 
            // lbtelefonopropietario
            // 
            this.lbtelefonopropietario.AutoSize = true;
            this.lbtelefonopropietario.ForeColor = System.Drawing.SystemColors.Control;
            this.lbtelefonopropietario.Location = new System.Drawing.Point(98, 149);
            this.lbtelefonopropietario.Name = "lbtelefonopropietario";
            this.lbtelefonopropietario.Size = new System.Drawing.Size(45, 13);
            this.lbtelefonopropietario.TabIndex = 12;
            this.lbtelefonopropietario.Text = "telefono";
            // 
            // lbcedulapropietario
            // 
            this.lbcedulapropietario.AutoSize = true;
            this.lbcedulapropietario.ForeColor = System.Drawing.SystemColors.Control;
            this.lbcedulapropietario.Location = new System.Drawing.Point(98, 121);
            this.lbcedulapropietario.Name = "lbcedulapropietario";
            this.lbcedulapropietario.Size = new System.Drawing.Size(39, 13);
            this.lbcedulapropietario.TabIndex = 11;
            this.lbcedulapropietario.Text = "cedula";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(11, 149);
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
            this.label7.Location = new System.Drawing.Point(11, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "CEDULA:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btsalir);
            this.panel3.Controls.Add(this.btgestionempleados);
            this.panel3.Location = new System.Drawing.Point(3, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 191);
            this.panel3.TabIndex = 3;
            // 
            // btsalir
            // 
            this.btsalir.BackColor = System.Drawing.Color.Green;
            this.btsalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btsalir.Location = new System.Drawing.Point(14, 128);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(134, 32);
            this.btsalir.TabIndex = 2;
            this.btsalir.Text = "Cerrar Sesion";
            this.btsalir.UseVisualStyleBackColor = false;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // btgestionempleados
            // 
            this.btgestionempleados.BackColor = System.Drawing.Color.Green;
            this.btgestionempleados.ForeColor = System.Drawing.SystemColors.Control;
            this.btgestionempleados.Location = new System.Drawing.Point(14, 40);
            this.btgestionempleados.Name = "btgestionempleados";
            this.btgestionempleados.Size = new System.Drawing.Size(134, 32);
            this.btgestionempleados.TabIndex = 8;
            this.btgestionempleados.Text = "gestion empleados";
            this.btgestionempleados.UseVisualStyleBackColor = false;
            this.btgestionempleados.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "USUARIO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(26, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ADMINISTRADOR";
            // 
            // lbusuariopropietario
            // 
            this.lbusuariopropietario.AutoSize = true;
            this.lbusuariopropietario.ForeColor = System.Drawing.SystemColors.Control;
            this.lbusuariopropietario.Location = new System.Drawing.Point(98, 95);
            this.lbusuariopropietario.Name = "lbusuariopropietario";
            this.lbusuariopropietario.Size = new System.Drawing.Size(42, 13);
            this.lbusuariopropietario.TabIndex = 2;
            this.lbusuariopropietario.Text = "nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DE SERVICIOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.btborrarservicio);
            this.panel2.Controls.Add(this.dgvservicios);
            this.panel2.Controls.Add(this.tbbuscarservicio);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btcrearservicio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(169, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 393);
            this.panel2.TabIndex = 0;
            // 
            // btborrarservicio
            // 
            this.btborrarservicio.BackColor = System.Drawing.Color.Green;
            this.btborrarservicio.ForeColor = System.Drawing.SystemColors.Control;
            this.btborrarservicio.Location = new System.Drawing.Point(157, 95);
            this.btborrarservicio.Name = "btborrarservicio";
            this.btborrarservicio.Size = new System.Drawing.Size(106, 32);
            this.btborrarservicio.TabIndex = 5;
            this.btborrarservicio.Text = "Borrar Servicio";
            this.btborrarservicio.UseVisualStyleBackColor = false;
            this.btborrarservicio.Click += new System.EventHandler(this.btborrarservicio_Click);
            // 
            // dgvservicios
            // 
            this.dgvservicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvservicios.Location = new System.Drawing.Point(80, 164);
            this.dgvservicios.Name = "dgvservicios";
            this.dgvservicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvservicios.Size = new System.Drawing.Size(453, 226);
            this.dgvservicios.TabIndex = 4;
            this.dgvservicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvservicios_CellClick);
            this.dgvservicios.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvservicios_CellEndEdit);
            // 
            // tbbuscarservicio
            // 
            this.tbbuscarservicio.Location = new System.Drawing.Point(348, 105);
            this.tbbuscarservicio.Name = "tbbuscarservicio";
            this.tbbuscarservicio.Size = new System.Drawing.Size(227, 20);
            this.tbbuscarservicio.TabIndex = 3;
            this.tbbuscarservicio.TextChanged += new System.EventHandler(this.tbbuscarservicio_TextChanged);
            this.tbbuscarservicio.Enter += new System.EventHandler(this.tbbuscarservicio_Enter);
            this.tbbuscarservicio.Leave += new System.EventHandler(this.tbbuscarservicio_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(345, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Buscar servicio";
            // 
            // btcrearservicio
            // 
            this.btcrearservicio.BackColor = System.Drawing.Color.Green;
            this.btcrearservicio.ForeColor = System.Drawing.SystemColors.Control;
            this.btcrearservicio.Location = new System.Drawing.Point(20, 95);
            this.btcrearservicio.Name = "btcrearservicio";
            this.btcrearservicio.Size = new System.Drawing.Size(106, 32);
            this.btcrearservicio.TabIndex = 1;
            this.btcrearservicio.Text = "Crear Servicio";
            this.btcrearservicio.UseVisualStyleBackColor = false;
            this.btcrearservicio.Click += new System.EventHandler(this.btcrearservicio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "SERVICIOS";
            // 
            // frmedicionservicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmedicionservicios";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvservicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbusuariopropietario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvservicios;
        private System.Windows.Forms.TextBox tbbuscarservicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btcrearservicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btborrarservicio;
        private System.Windows.Forms.Label lbtelefonopropietario;
        private System.Windows.Forms.Label lbcedulapropietario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btgestionempleados;
    }
}