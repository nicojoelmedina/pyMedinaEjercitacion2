using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pyMedinaEjercitacion2
{
    public partial class frmIncidentes : Form
    {
        public frmIncidentes()
        {
            InitializeComponent();
        }

        private void frmIncidentes_Load(object sender, EventArgs e)
        {
            lblResultadoCritico.BackColor = Color.Red;
            lblResultadoCritico.Text = "100 %";
        }
    }
}
