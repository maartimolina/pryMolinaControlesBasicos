namespace pryMolinaControlesBasicos
{
    partial class frmSecundario
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
            this.lblMostrar = new System.Windows.Forms.Label();
            this.txtSecundario = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.chkSpinetta = new System.Windows.Forms.CheckBox();
            this.chkCharly = new System.Windows.Forms.CheckBox();
            this.chkCerati = new System.Windows.Forms.CheckBox();
            this.mrcOpciones = new System.Windows.Forms.GroupBox();
            this.mrcOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.Location = new System.Drawing.Point(341, 236);
            this.lblMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(379, 29);
            this.lblMostrar.TabIndex = 0;
            this.lblMostrar.Text = "El mensaje se mostrará aquí...";
            // 
            // txtSecundario
            // 
            this.txtSecundario.Location = new System.Drawing.Point(346, 88);
            this.txtSecundario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecundario.Name = "txtSecundario";
            this.txtSecundario.Size = new System.Drawing.Size(374, 22);
            this.txtSecundario.TabIndex = 1;
            this.txtSecundario.TextChanged += new System.EventHandler(this.txtSecundario_TextChanged);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(454, 176);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(135, 43);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(437, 458);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(135, 43);
            this.btnEscribir.TabIndex = 3;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRojo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optRojo.Location = new System.Drawing.Point(399, 125);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(85, 33);
            this.optRojo.TabIndex = 4;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            this.optRojo.CheckedChanged += new System.EventHandler(this.btnRojo_CheckedChanged);
            this.optRojo.ForeColorChanged += new System.EventHandler(this.btnRojo_CheckedChanged);
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAzul.Location = new System.Drawing.Point(572, 125);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(79, 33);
            this.optAzul.TabIndex = 5;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // chkSpinetta
            // 
            this.chkSpinetta.AutoSize = true;
            this.chkSpinetta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpinetta.Location = new System.Drawing.Point(21, 111);
            this.chkSpinetta.Name = "chkSpinetta";
            this.chkSpinetta.Size = new System.Drawing.Size(123, 33);
            this.chkSpinetta.TabIndex = 6;
            this.chkSpinetta.Text = "Spinetta";
            this.chkSpinetta.UseVisualStyleBackColor = true;
            // 
            // chkCharly
            // 
            this.chkCharly.AutoSize = true;
            this.chkCharly.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCharly.Location = new System.Drawing.Point(21, 72);
            this.chkCharly.Name = "chkCharly";
            this.chkCharly.Size = new System.Drawing.Size(103, 33);
            this.chkCharly.TabIndex = 7;
            this.chkCharly.Text = "Charly";
            this.chkCharly.UseVisualStyleBackColor = true;
            // 
            // chkCerati
            // 
            this.chkCerati.AutoSize = true;
            this.chkCerati.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCerati.Location = new System.Drawing.Point(25, 33);
            this.chkCerati.Name = "chkCerati";
            this.chkCerati.Size = new System.Drawing.Size(99, 33);
            this.chkCerati.TabIndex = 8;
            this.chkCerati.Text = "Cerati";
            this.chkCerati.UseVisualStyleBackColor = true;
            // 
            // mrcOpciones
            // 
            this.mrcOpciones.Controls.Add(this.chkCerati);
            this.mrcOpciones.Controls.Add(this.chkSpinetta);
            this.mrcOpciones.Controls.Add(this.chkCharly);
            this.mrcOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcOpciones.Location = new System.Drawing.Point(360, 297);
            this.mrcOpciones.Name = "mrcOpciones";
            this.mrcOpciones.Size = new System.Drawing.Size(309, 155);
            this.mrcOpciones.TabIndex = 9;
            this.mrcOpciones.TabStop = false;
            this.mrcOpciones.Text = "Opciones";
            // 
            // frmSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mrcOpciones);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txtSecundario);
            this.Controls.Add(this.lblMostrar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSecundario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secundario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDos_Load);
            this.mrcOpciones.ResumeLayout(false);
            this.mrcOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.TextBox txtSecundario;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.CheckBox chkSpinetta;
        private System.Windows.Forms.CheckBox chkCharly;
        private System.Windows.Forms.CheckBox chkCerati;
        private System.Windows.Forms.GroupBox mrcOpciones;
    }
}