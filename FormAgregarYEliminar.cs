using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficheros_XML
{
    public partial class FormAgregarYEliminar : Form
    {
        public FormAgregarYEliminar()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAceptar.Text.Equals("Añadir"))
            {
                txtDni.Text = "";
                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtEdad.Text = "";
                txtTelefono.Text = "";
                txtCuenta.Text = "";


            }
            else if (btnAceptar.Text.Equals("Eliminar"))
            { 
            
            }
        }

        private void txtComprobarNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
