namespace pryMolinaControlesBasicos
{
    partial class frmControlesBasicos
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
            this.lblEjeX = new System.Windows.Forms.Label();
            this.lblEjeY = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEjeX
            // 
            this.lblEjeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeX.AutoSize = true;
            this.lblEjeX.Location = new System.Drawing.Point(671, 143);
            this.lblEjeX.Name = "lblEjeX";
            this.lblEjeX.Size = new System.Drawing.Size(14, 13);
            this.lblEjeX.TabIndex = 0;
            this.lblEjeX.Text = "X";
            this.lblEjeX.Click += new System.EventHandler(this.label1_Click);
            this.lblEjeX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblx_MouseMove);
            // 
            // lblEjeY
            // 
            this.lblEjeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeY.AutoSize = true;
            this.lblEjeY.Location = new System.Drawing.Point(671, 71);
            this.lblEjeY.Name = "lblEjeY";
            this.lblEjeY.Size = new System.Drawing.Size(14, 13);
            this.lblEjeY.TabIndex = 1;
            this.lblEjeY.Text = "Y";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBienvenida.Location = new System.Drawing.Point(273, 153);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(210, 42);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "Bienvenida";
            this.lblBienvenida.Visible = false;
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            this.lblBienvenida.MouseEnter += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // frmControlesBasicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblEjeY);
            this.Controls.Add(this.lblEjeX);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmControlesBasicos";
            this.Text = "Controles Basicos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmControlesBasicos_Load_1);
            this.Click += new System.EventHandler(this.frmControlesBasicos_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmControlesBasicos_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEjeX;
        private System.Windows.Forms.Label lblEjeY;
        private System.Windows.Forms.Label lblBienvenida;
    }
}

