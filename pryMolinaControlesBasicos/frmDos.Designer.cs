namespace pryMolinaControlesBasicos
{
    partial class frmDos
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
            this.lblDos = new System.Windows.Forms.Label();
            this.txtDos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDos
            // 
            this.lblDos.AutoSize = true;
            this.lblDos.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDos.Location = new System.Drawing.Point(364, 122);
            this.lblDos.Name = "lblDos";
            this.lblDos.Size = new System.Drawing.Size(47, 23);
            this.lblDos.TabIndex = 0;
            this.lblDos.Text = "Dos";
            // 
            // txtDos
            // 
            this.txtDos.Location = new System.Drawing.Point(433, 125);
            this.txtDos.Name = "txtDos";
            this.txtDos.Size = new System.Drawing.Size(190, 20);
            this.txtDos.TabIndex = 1;
            // 
            // frmDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDos);
            this.Controls.Add(this.lblDos);
            this.Name = "frmDos";
            this.Text = "frmDos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDos;
        private System.Windows.Forms.TextBox txtDos;
    }
}