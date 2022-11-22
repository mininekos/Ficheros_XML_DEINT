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
    public partial class FormModificar : Form
    {
        public FormModificar()
        {
            InitializeComponent();
        }

        private void btnOpcion_Click(object sender, EventArgs e)
        {
            FormAgregarYEliminar form=new FormAgregarYEliminar();
            
            if (btnOpcion.Text.Equals("Eliminar")) {
                form.btnAceptar.Text = "Eliminar";
                form.Text = "Elimimnar cliente";
                form.ShowDialog();
            }
            else if (btnOpcion.Text.Equals("Modificar")) {
                form.btnAceptar.Text = "Modificar";
                form.Text = "Modificar cliente";
                form.ShowDialog();
            }

            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
