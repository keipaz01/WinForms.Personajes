namespace elWinForms
{
    partial class frmZonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZonas));
            this.cmbZonas = new System.Windows.Forms.ComboBox();
            this.lblZonas = new System.Windows.Forms.Label();
            this.picZonaSeleccionada = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaSeleccionada)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbZonas
            // 
            this.cmbZonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZonas.FormattingEnabled = true;
            this.cmbZonas.Location = new System.Drawing.Point(12, 83);
            this.cmbZonas.Name = "cmbZonas";
            this.cmbZonas.Size = new System.Drawing.Size(121, 21);
            this.cmbZonas.TabIndex = 1;
            this.cmbZonas.SelectedIndexChanged += new System.EventHandler(this.cmbZonas_SelectedIndexChanged);
            // 
            // lblZonas
            // 
            this.lblZonas.AutoSize = true;
            this.lblZonas.Location = new System.Drawing.Point(47, 64);
            this.lblZonas.Name = "lblZonas";
            this.lblZonas.Size = new System.Drawing.Size(40, 13);
            this.lblZonas.TabIndex = 2;
            this.lblZonas.Text = "Zonas:";
            // 
            // picZonaSeleccionada
            // 
            this.picZonaSeleccionada.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picZonaSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picZonaSeleccionada.Location = new System.Drawing.Point(151, 64);
            this.picZonaSeleccionada.Name = "picZonaSeleccionada";
            this.picZonaSeleccionada.Size = new System.Drawing.Size(150, 150);
            this.picZonaSeleccionada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picZonaSeleccionada.TabIndex = 3;
            this.picZonaSeleccionada.TabStop = false;
            // 
            // frmZonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 275);
            this.Controls.Add(this.picZonaSeleccionada);
            this.Controls.Add(this.lblZonas);
            this.Controls.Add(this.cmbZonas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmZonas";
            this.Text = "Zonas";
            this.Load += new System.EventHandler(this.frmZonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picZonaSeleccionada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbZonas;
        private System.Windows.Forms.Label lblZonas;
        private System.Windows.Forms.PictureBox picZonaSeleccionada;
    }
}