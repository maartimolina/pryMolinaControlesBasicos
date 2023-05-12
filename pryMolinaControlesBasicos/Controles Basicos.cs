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
    public partial class frmControlesBasicos : Form
    {
        public frmControlesBasicos()
        {
            InitializeComponent();
        }

        private void frmControlesBasicos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblx_MouseMove(object sender, MouseEventArgs e)
        {
            

        }

        private void frmControlesBasicos_MouseMove(object sender, MouseEventArgs e)
        {
            lblEjeX.Text = e.X.ToString();
            lblEjeY.Text = e.Y.ToString();
        }

        private void frmControlesBasicos_Load_1(object sender, EventArgs e)
        {

        }

        private void frmControlesBasicos_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = true;

        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {
            lblBienvenida.Location = new Point(24, 18);
        }
    }
}
