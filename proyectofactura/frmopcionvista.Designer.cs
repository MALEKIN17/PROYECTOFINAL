namespace proyectofactura
{
    partial class frmopcionvista
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
            this.label1 = new System.Windows.Forms.Label();
            this.btvistaadministrador = new System.Windows.Forms.Button();
            this.btvistaempleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "A Que Vista Quiere ir?";
            // 
            // btvistaadministrador
            // 
            this.btvistaadministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvistaadministrador.Location = new System.Drawing.Point(12, 43);
            this.btvistaadministrador.Name = "btvistaadministrador";
            this.btvistaadministrador.Size = new System.Drawing.Size(104, 34);
            this.btvistaadministrador.TabIndex = 1;
            this.btvistaadministrador.Text = "Administrador";
            this.btvistaadministrador.UseVisualStyleBackColor = true;
            this.btvistaadministrador.Click += new System.EventHandler(this.button1_Click);
            // 
            // btvistaempleado
            // 
            this.btvistaempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvistaempleado.Location = new System.Drawing.Point(168, 43);
            this.btvistaempleado.Name = "btvistaempleado";
            this.btvistaempleado.Size = new System.Drawing.Size(104, 34);
            this.btvistaempleado.TabIndex = 2;
            this.btvistaempleado.Text = "Empleado";
            this.btvistaempleado.UseVisualStyleBackColor = true;
            this.btvistaempleado.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmopcionvista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(299, 108);
            this.Controls.Add(this.btvistaempleado);
            this.Controls.Add(this.btvistaadministrador);
            this.Controls.Add(this.label1);
            this.Name = "frmopcionvista";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btvistaadministrador;
        private System.Windows.Forms.Button btvistaempleado;
    }
}