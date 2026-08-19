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
        //ZONA VARIABLES GLOBALES
        // contadores
        int vContadorCritico;
        int vContadorAlto;
        int vContadorMedio;
        int vContadorBajo;
        
        public frmIncidentes()
        {
            InitializeComponent();
        }

        private void lblCritico_Click(object sender, EventArgs e)
        {
            vContadorCritico = vContadorCritico + 1;

            lblResultadoCritico.BackColor = Color.Red;
            lblResultadoCritico.Text = vContadorCritico.ToString();
        }

        private void lblAlto_Click(object sender, EventArgs e)
        {
            vContadorAlto = vContadorAlto + 1;

            lblResultadoAlto.BackColor = Color. Gray;
            lblResultadoAlto.Text = vContadorAlto.ToString();
        }

        private void lblMedio_Click(object sender, EventArgs e)
        {
            vContadorMedio = vContadorMedio + 1;

            lblResultadoMedio.BackColor = Color.Yellow;
            lblResultadoMedio.Text = vContadorMedio.ToString();
        }

        private void lblBajo_Click(object sender, EventArgs e)
        {
            vContadorBajo = vContadorBajo + 1;

            lblResultadoBajo.BackColor = Color.Green;
            lblResultadoBajo.Text = vContadorBajo.ToString();
        }
    }
}
