namespace proyectofactura
{
    partial class frmregistroservicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbprecioservicio = new System.Windows.Forms.TextBox();
            this.tbnombreservicio = new System.Windows.Forms.TextBox();
            this.btregistrarservicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectofactura.Properties.Resources.servicio;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "nombre del servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "precio del servicio";
            // 
            // tbprecioservicio
            // 
            this.tbprecioservicio.Location = new System.Drawing.Point(277, 93);
            this.tbprecioservicio.Name = "tbprecioservicio";
            this.tbprecioservicio.Size = new System.Drawing.Size(100, 20);
            this.tbprecioservicio.TabIndex = 3;
            // 
            // tbnombreservicio
            // 
            this.tbnombreservicio.Location = new System.Drawing.Point(12, 93);
            this.tbnombreservicio.Name = "tbnombreservicio";
            this.tbnombreservicio.Size = new System.Drawing.Size(236, 20);
            this.tbnombreservicio.TabIndex = 4;
            // 
            // btregistrarservicio
            // 
            this.btregistrarservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregistrarservicio.Location = new System.Drawing.Point(191, 227);
            this.btregistrarservicio.Name = "btregistrarservicio";
            this.btregistrarservicio.Size = new System.Drawing.Size(86, 32);
            this.btregistrarservicio.TabIndex = 5;
            this.btregistrarservicio.Text = "Registrar";
            this.btregistrarservicio.UseVisualStyleBackColor = true;
            this.btregistrarservicio.Click += new System.EventHandler(this.btregistrarservicio_Click);
            // 
            // frmregistroservicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 300);
            this.Controls.Add(this.btregistrarservicio);
            this.Controls.Add(this.tbnombreservicio);
            this.Controls.Add(this.tbprecioservicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmregistroservicio";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbprecioservicio;
        private System.Windows.Forms.TextBox tbnombreservicio;
        private System.Windows.Forms.Button btregistrarservicio;
    }
}