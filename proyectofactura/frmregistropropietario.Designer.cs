namespace proyectofactura
{
    partial class frmregistropropietario
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
            this.btregistropropietario = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbcedulapropietario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbnombrepropietario = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbapellidopropietario = new System.Windows.Forms.TextBox();
            this.tbtelefonopropietario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbusuariopropietario = new System.Windows.Forms.TextBox();
            this.tbcontraseñapropietario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectofactura.Properties.Resources.reparacion_login_auto_x2_colored_toned_light_ai;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btregistropropietario
            // 
            this.btregistropropietario.Location = new System.Drawing.Point(174, 319);
            this.btregistropropietario.Name = "btregistropropietario";
            this.btregistropropietario.Size = new System.Drawing.Size(85, 23);
            this.btregistropropietario.TabIndex = 5;
            this.btregistropropietario.Text = "CONFIRMAR";
            this.btregistropropietario.UseVisualStyleBackColor = true;
            this.btregistropropietario.Click += new System.EventHandler(this.btregistropropietario_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.tbcontraseñapropietario);
            this.panel3.Controls.Add(this.tbusuariopropietario);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.tbcedulapropietario);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.tbnombrepropietario);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.tbapellidopropietario);
            this.panel3.Controls.Add(this.tbtelefonopropietario);
            this.panel3.Location = new System.Drawing.Point(100, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 186);
            this.panel3.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "CEDULA:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "TELEFONO:";
            // 
            // tbcedulapropietario
            // 
            this.tbcedulapropietario.Location = new System.Drawing.Point(84, 11);
            this.tbcedulapropietario.Name = "tbcedulapropietario";
            this.tbcedulapropietario.Size = new System.Drawing.Size(119, 20);
            this.tbcedulapropietario.TabIndex = 2;
            this.tbcedulapropietario.Enter += new System.EventHandler(this.tbcedulapropietario_Enter);
            this.tbcedulapropietario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcedulapropietario_KeyPress);
            this.tbcedulapropietario.Leave += new System.EventHandler(this.tbcedulapropietario_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "APELLIDO:";
            // 
            // tbnombrepropietario
            // 
            this.tbnombrepropietario.Location = new System.Drawing.Point(84, 37);
            this.tbnombrepropietario.Name = "tbnombrepropietario";
            this.tbnombrepropietario.Size = new System.Drawing.Size(119, 20);
            this.tbnombrepropietario.TabIndex = 3;
            this.tbnombrepropietario.Enter += new System.EventHandler(this.tbnombrepropietario_Enter);
            this.tbnombrepropietario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnombrepropietario_KeyPress);
            this.tbnombrepropietario.Leave += new System.EventHandler(this.tbnombrepropietario_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "NOMBRE:";
            // 
            // tbapellidopropietario
            // 
            this.tbapellidopropietario.Location = new System.Drawing.Point(84, 63);
            this.tbapellidopropietario.Name = "tbapellidopropietario";
            this.tbapellidopropietario.Size = new System.Drawing.Size(119, 20);
            this.tbapellidopropietario.TabIndex = 4;
            this.tbapellidopropietario.Enter += new System.EventHandler(this.tbapellidopropietario_Enter);
            this.tbapellidopropietario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbapellidopropietario_KeyPress);
            this.tbapellidopropietario.Leave += new System.EventHandler(this.tbapellidopropietario_Leave);
            // 
            // tbtelefonopropietario
            // 
            this.tbtelefonopropietario.Location = new System.Drawing.Point(84, 89);
            this.tbtelefonopropietario.Name = "tbtelefonopropietario";
            this.tbtelefonopropietario.Size = new System.Drawing.Size(119, 20);
            this.tbtelefonopropietario.TabIndex = 5;
            this.tbtelefonopropietario.Enter += new System.EventHandler(this.tbtelefonopropietario_Enter);
            this.tbtelefonopropietario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtelefonopropietario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "CONTRASEÑA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "USUARIO:";
            // 
            // tbusuariopropietario
            // 
            this.tbusuariopropietario.Location = new System.Drawing.Point(84, 115);
            this.tbusuariopropietario.Name = "tbusuariopropietario";
            this.tbusuariopropietario.Size = new System.Drawing.Size(119, 20);
            this.tbusuariopropietario.TabIndex = 13;
            // 
            // tbcontraseñapropietario
            // 
            this.tbcontraseñapropietario.Location = new System.Drawing.Point(100, 141);
            this.tbcontraseñapropietario.Name = "tbcontraseñapropietario";
            this.tbcontraseñapropietario.Size = new System.Drawing.Size(119, 20);
            this.tbcontraseñapropietario.TabIndex = 14;
            // 
            // frmregistropropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.btregistropropietario);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmregistropropietario";
            this.Text = "2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btregistropropietario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbcedulapropietario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbnombrepropietario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbapellidopropietario;
        private System.Windows.Forms.TextBox tbtelefonopropietario;
        private System.Windows.Forms.TextBox tbcontraseñapropietario;
        private System.Windows.Forms.TextBox tbusuariopropietario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}