namespace proyectofactura
{
    partial class frmfacturascliente
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
            this.tbbuscarfactura = new System.Windows.Forms.TextBox();
            this.dtgfacturascliente = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgfacturascliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar factura";
            // 
            // tbbuscarfactura
            // 
            this.tbbuscarfactura.Location = new System.Drawing.Point(535, 65);
            this.tbbuscarfactura.Name = "tbbuscarfactura";
            this.tbbuscarfactura.Size = new System.Drawing.Size(163, 20);
            this.tbbuscarfactura.TabIndex = 2;
            this.tbbuscarfactura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbbuscarfactura.Enter += new System.EventHandler(this.tbbuscarfactura_Enter);
            this.tbbuscarfactura.Leave += new System.EventHandler(this.tbbuscarfactura_Leave);
            // 
            // dtgfacturascliente
            // 
            this.dtgfacturascliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgfacturascliente.Location = new System.Drawing.Point(108, 110);
            this.dtgfacturascliente.Name = "dtgfacturascliente";
            this.dtgfacturascliente.Size = new System.Drawing.Size(590, 150);
            this.dtgfacturascliente.TabIndex = 3;
            this.dtgfacturascliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgfacturascliente_CellDoubleClick);
            this.dtgfacturascliente.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgfacturascliente_CellEndEdit);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(29, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectofactura.Properties.Resources.FACTURACION;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmfacturascliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgfacturascliente);
            this.Controls.Add(this.tbbuscarfactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmfacturascliente";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dtgfacturascliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbbuscarfactura;
        private System.Windows.Forms.DataGridView dtgfacturascliente;
        private System.Windows.Forms.Button button1;
    }
}