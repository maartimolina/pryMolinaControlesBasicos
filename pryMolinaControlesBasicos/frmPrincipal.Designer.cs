namespace pryMolinaControlesBasicos
{
    partial class frmPrincipal
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
            this.btnSecundario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEjeX
            // 
            this.lblEjeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeX.AutoSize = true;
            this.lblEjeX.Location = new System.Drawing.Point(895, 176);
            this.lblEjeX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEjeX.Name = "lblEjeX";
            this.lblEjeX.Size = new System.Drawing.Size(15, 16);
            this.lblEjeX.TabIndex = 0;
            this.lblEjeX.Text = "X";
            this.lblEjeX.Click += new System.EventHandler(this.label1_Click);
            this.lblEjeX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblx_MouseMove);
            // 
            // lblEjeY
            // 
            this.lblEjeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeY.AutoSize = true;
            this.lblEjeY.Location = new System.Drawing.Point(895, 87);
            this.lblEjeY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEjeY.Name = "lblEjeY";
            this.lblEjeY.Size = new System.Drawing.Size(16, 16);
            this.lblEjeY.TabIndex = 1;
            this.lblEjeY.Text = "Y";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBienvenida.Location = new System.Drawing.Point(272, 161);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(480, 97);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "Bienvenida";
            this.lblBienvenida.Visible = false;
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            this.lblBienvenida.MouseEnter += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // btnSecundario
            // 
            this.btnSecundario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSecundario.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecundario.Location = new System.Drawing.Point(377, 311);
            this.btnSecundario.Name = "btnSecundario";
            this.btnSecundario.Size = new System.Drawing.Size(278, 84);
            this.btnSecundario.TabIndex = 3;
            this.btnSecundario.Text = "Secundario";
            this.btnSecundario.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSecundario);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblEjeY);
            this.Controls.Add(this.lblEjeX);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
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
        private System.Windows.Forms.Button btnSecundario;
    }
}

