using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_PROGRAMACION_DSCV__1
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtnumerotel_Validating(object sender, CancelEventArgs e)
        {
            string mensaje = ValidacionCliente.ValidarTelefono(txtnumerotel.Text);
            errprovider.SetError(txtnumerotel, mensaje);
            lblerrortel.Text = mensaje;

        }

        private void txtnumerotel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
