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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarYEliminar formAgregar = new FormAgregarYEliminar();
            formAgregar.btnAceptar.Text = "Añadir";
            formAgregar.Text = "Añadir nuevo cliente";
            formAgregar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormAgregarYEliminar formEliminar = new FormAgregarYEliminar();
            formEliminar.btnAceptar.Text = "Eliminar";
            formEliminar.Text = "Eliminar cliente";
            formEliminar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificar formModificar = new FormModificar();
            formModificar.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FormMostrar formMostrar = new FormMostrar();
            formMostrar.ShowDialog();
        }
    }
}
