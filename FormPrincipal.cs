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
    public partial class Menu : Form
    {
        public Menu()
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
            FormModificar formEliminar = new FormModificar();
            formEliminar.Text = "Eliminar cliente";
            formEliminar.btnOpcion.Text = "Eliminar";
            formEliminar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificar formModificar = new FormModificar();
            formModificar.Text = "Modificar cliente";
            formModificar.btnOpcion.Text = "Modificar";
            formModificar.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FormMostrar formMostrar = new FormMostrar();
            formMostrar.ShowDialog();
        }
    }
}
