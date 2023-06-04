using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMolinaControlesBasicos
{
    public partial class frmSecundario : Form
    {
        public frmSecundario()
        {
            InitializeComponent();
        }

        private void frmDos_Load(object sender, EventArgs e)
        {

        }

        private void btnRojo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSecundario_TextChanged(object sender, EventArgs e)
        {
            lblMostrar.Text = txtSecundario.Text;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (optAzul.Checked)
            {
                txtSecundario.ForeColor = Color.Blue;
                lblMostrar.ForeColor = Color.Blue;
            }
            else if (optRojo.Checked)
            {
                txtSecundario.ForeColor = Color.Red;
                lblMostrar.ForeColor = Color.Red;
            }
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {

            lblMostrar.Text = "";
            if (chkCerati.Checked)
            {
                lblMostrar.Text += chkCerati.Text + " ";
            }
            if (chkCharly.Checked)
            {
                lblMostrar.Text += chkCharly.Text + " ";
            }
            if (chkSpinetta.Checked)
            {
                lblMostrar.Text += chkSpinetta.Text + " ";
            }
            if (chkCerati.Checked == false && chkCharly.Checked == false && chkSpinetta.Checked == false)
            {
                lblMostrar.Text = "Su mensaje se mostrará aquí";
            }
        }
    }
}
