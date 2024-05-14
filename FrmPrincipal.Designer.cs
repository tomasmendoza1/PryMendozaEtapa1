namespace PryMendozaEtapa1
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptcRegistrarFirmar = new System.Windows.Forms.PictureBox();
            this.BtnComenzar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptcRegistrarFirmar)).BeginInit();
            this.SuspendLayout();
            // 
            // ptcRegistrarFirmar
            // 
            this.ptcRegistrarFirmar.Location = new System.Drawing.Point(12, 12);
            this.ptcRegistrarFirmar.Name = "ptcRegistrarFirmar";
            this.ptcRegistrarFirmar.Size = new System.Drawing.Size(575, 247);
            this.ptcRegistrarFirmar.TabIndex = 0;
            this.ptcRegistrarFirmar.TabStop = false;
            this.ptcRegistrarFirmar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptcRegistrarFirmar_MouseDown);
            this.ptcRegistrarFirmar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptcRegistrarFirmar_MouseMove);
            this.ptcRegistrarFirmar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptcRegistrarFirmar_MouseUp);
            // 
            // BtnComenzar
            // 
            this.BtnComenzar.Location = new System.Drawing.Point(12, 265);
            this.BtnComenzar.Name = "BtnComenzar";
            this.BtnComenzar.Size = new System.Drawing.Size(178, 34);
            this.BtnComenzar.TabIndex = 1;
            this.BtnComenzar.Text = "Comezar";
            this.BtnComenzar.UseVisualStyleBackColor = true;
            this.BtnComenzar.Click += new System.EventHandler(this.BtnComenzar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(398, 265);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(189, 34);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(196, 266);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(196, 34);
            this.BtnCerrar.TabIndex = 3;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(599, 312);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnComenzar);
            this.Controls.Add(this.ptcRegistrarFirmar);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etapa 1 - DIBUJAR";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcRegistrarFirmar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcRegistrarFirmar;
        private System.Windows.Forms.Button BtnComenzar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCerrar;
    }
}

