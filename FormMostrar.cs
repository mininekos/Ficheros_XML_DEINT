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
    public partial class FormMostrar : Form
    {
        Banco banco;
        public FormMostrar(Banco banco)
        {
            this.banco = banco;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMostrar_Load(object sender, EventArgs e)
        {
            dgClientes.DataSource = banco.ListaCLientes;
        }
    }
}
