using Ficheros_XML.Clases;
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
        Banco banco;
        public FormModificar(Banco banco)
        {
            this.banco = banco;
            InitializeComponent();
        }

        private void btnOpcion_Click(object sender, EventArgs e)
        {
            if (cbDNI.Text!="")
            {
                FormAgregarYEliminar form = new FormAgregarYEliminar(banco, cbDNI.Text);

                if (btnOpcion.Text.Equals("Eliminar"))
                {
                    form.btnAceptar.Text = "Eliminar";
                    form.Text = "Elimimnar cliente";
                    form.ShowDialog();
                }
                else if (btnOpcion.Text.Equals("Modificar"))
                {
                    form.btnAceptar.Text = "Modificar";
                    form.Text = "Modificar cliente";
                    form.ShowDialog();
                }

                Close();
            }
            else {
                MessageBox.Show("Cliente no seleccionado");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            foreach (Cliente cliente in banco.ListaCLientes) { 
                cbDNI.Items.Add(cliente.DNI);              
            }
        }
    }
}
