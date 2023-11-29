namespace proyectofactura
{
    partial class frmingreso
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
            this.btregistrarse = new System.Windows.Forms.Button();
            this.tbcontraseña = new System.Windows.Forms.TextBox();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.btingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbclave = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbclave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btregistrarse);
            this.panel1.Controls.Add(this.tbcontraseña);
            this.panel1.Controls.Add(this.tbusuario);
            this.panel1.Controls.Add(this.btingresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(305, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 266);
            this.panel1.TabIndex = 1;
            // 
            // btregistrarse
            // 
            this.btregistrarse.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregistrarse.Location = new System.Drawing.Point(63, 212);
            this.btregistrarse.Name = "btregistrarse";
            this.btregistrarse.Size = new System.Drawing.Size(134, 28);
            this.btregistrarse.TabIndex = 4;
            this.btregistrarse.Text = "REGISTRARSE";
            this.btregistrarse.UseVisualStyleBackColor = true;
            this.btregistrarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbcontraseña
            // 
            this.tbcontraseña.Location = new System.Drawing.Point(20, 94);
            this.tbcontraseña.Name = "tbcontraseña";
            this.tbcontraseña.Size = new System.Drawing.Size(217, 20);
            this.tbcontraseña.TabIndex = 3;
            this.tbcontraseña.Enter += new System.EventHandler(this.tbcontraseña_Enter);
            this.tbcontraseña.Leave += new System.EventHandler(this.tbcontraseña_Leave);
            // 
            // tbusuario
            // 
            this.tbusuario.Location = new System.Drawing.Point(20, 61);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(217, 20);
            this.tbusuario.TabIndex = 2;
            this.tbusuario.Enter += new System.EventHandler(this.tbusuario_Enter);
            this.tbusuario.Leave += new System.EventHandler(this.tbusuario_Leave);
            // 
            // btingresar
            // 
            this.btingresar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btingresar.Location = new System.Drawing.Point(78, 129);
            this.btingresar.Name = "btingresar";
            this.btingresar.Size = new System.Drawing.Size(106, 28);
            this.btingresar.TabIndex = 1;
            this.btingresar.Text = "INGRESAR";
            this.btingresar.UseVisualStyleBackColor = true;
            this.btingresar.Click += new System.EventHandler(this.btingresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectofactura.Properties.Resources.reparacion_lg;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(854, 447);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CLAVE";
            // 
            // tbclave
            // 
            this.tbclave.Location = new System.Drawing.Point(96, 172);
            this.tbclave.Name = "tbclave";
            this.tbclave.Size = new System.Drawing.Size(88, 20);
            this.tbclave.TabIndex = 6;
            this.tbclave.Enter += new System.EventHandler(this.tbclave_Enter);
            this.tbclave.Leave += new System.EventHandler(this.tbclave_Leave);
            // 
            // frmingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmingreso";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbcontraseña;
        private System.Windows.Forms.TextBox tbusuario;
        private System.Windows.Forms.Button btingresar;
        private System.Windows.Forms.Button btregistrarse;
        private System.Windows.Forms.TextBox tbclave;
        private System.Windows.Forms.Label label2;
    }
}