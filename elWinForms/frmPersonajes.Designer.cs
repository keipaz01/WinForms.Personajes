namespace elWinForms
{
    partial class frmPersonajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonajes));
            this.lblChara = new System.Windows.Forms.Label();
            this.cmbPersonajes = new System.Windows.Forms.ComboBox();
            this.picPersonajeSeleccionado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZonas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonajeSeleccionado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChara
            // 
            this.lblChara.AutoSize = true;
            this.lblChara.Location = new System.Drawing.Point(58, 85);
            this.lblChara.Name = "lblChara";
            this.lblChara.Size = new System.Drawing.Size(57, 13);
            this.lblChara.TabIndex = 0;
            this.lblChara.Text = "Personaje:";
            // 
            // cmbPersonajes
            // 
            this.cmbPersonajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonajes.FormattingEnabled = true;
            this.cmbPersonajes.Location = new System.Drawing.Point(12, 114);
            this.cmbPersonajes.Name = "cmbPersonajes";
            this.cmbPersonajes.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonajes.TabIndex = 2;
            this.cmbPersonajes.SelectedIndexChanged += new System.EventHandler(this.cmbPersonajes_SelectedIndexChanged);
            // 
            // picPersonajeSeleccionado
            // 
            this.picPersonajeSeleccionado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picPersonajeSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPersonajeSeleccionado.Location = new System.Drawing.Point(181, 12);
            this.picPersonajeSeleccionado.Name = "picPersonajeSeleccionado";
            this.picPersonajeSeleccionado.Size = new System.Drawing.Size(353, 327);
            this.picPersonajeSeleccionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonajeSeleccionado.TabIndex = 4;
            this.picPersonajeSeleccionado.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 48);
            this.label1.TabIndex = 0;
            // 
            // btnZonas
            // 
            this.btnZonas.Location = new System.Drawing.Point(61, 168);
            this.btnZonas.Name = "btnZonas";
            this.btnZonas.Size = new System.Drawing.Size(75, 23);
            this.btnZonas.TabIndex = 7;
            this.btnZonas.Text = "Zonas";
            this.btnZonas.UseVisualStyleBackColor = true;
            this.btnZonas.Click += new System.EventHandler(this.btnZonas_Click);
            // 
            // frmPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 380);
            this.Controls.Add(this.btnZonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPersonajeSeleccionado);
            this.Controls.Add(this.cmbPersonajes);
            this.Controls.Add(this.lblChara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersonajes";
            this.Text = "Personajes";
            this.Load += new System.EventHandler(this.frmPersonajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPersonajeSeleccionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChara;
        private System.Windows.Forms.ComboBox cmbPersonajes;
        private System.Windows.Forms.PictureBox picPersonajeSeleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZonas;
    }
}

