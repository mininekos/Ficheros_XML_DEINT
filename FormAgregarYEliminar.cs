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

    public partial class FormAgregarYEliminar : Form
    {
        Banco banco;
        String dni;
        public FormAgregarYEliminar(Banco banco, String dni)
        {
            this.dni = dni;
            this.banco = banco;
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
                banco.ListaCLientes.Add(new Cliente(txtDni.Text, txtNombre.Text, txtDireccion.Text,
                    Int64.Parse(txtEdad.Text), Int64.Parse(txtTelefono.Text), Int64.Parse(txtCuenta.Text)));
                
                txtDni.Text = "";
                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtEdad.Text = "";
                txtTelefono.Text = "";
                txtCuenta.Text = "";
                
                MessageBox.Show("Cliente agregado");

            }
            else if (btnAceptar.Text.Equals("Eliminar"))
            {
                MessageBox.Show("Cliente eliminado");
                banco.ListaCLientes.Remove(banco.ListaCLientes.Find(c => c.Equals(new Cliente(dni))));
                Close();
            }
            else if (btnAceptar.Text.Equals("Modificar")){
                Cliente clientViejo=banco.ListaCLientes.Find(c => c.Equals(new Cliente(dni)));
                int ind =banco.ListaCLientes.IndexOf(clientViejo);
                banco.ListaCLientes[ind]= new Cliente(txtDni.Text, txtNombre.Text, txtDireccion.Text,
                    Int64.Parse(txtEdad.Text), Int64.Parse(txtTelefono.Text), Int64.Parse(txtCuenta.Text));
                MessageBox.Show("Cliente modificado");
                Close();
            }
        }

        private void txtComprobarNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormAgregarYEliminar_Load(object sender, EventArgs e)
        {
            if (btnAceptar.Text.Equals("Eliminar"))
            {
                txtDni.Enabled = false;
                txtNombre.Enabled = false;
                txtDireccion.Enabled = false;
                txtEdad.Enabled = false;
                txtTelefono.Enabled = false;
                txtCuenta.Enabled = false;
                cargarCliente();
            }
            else if (btnAceptar.Text.Equals("Modificar")) {
                cargarCliente();
            }
            
        }

        private void cargarCliente() {
            
            Cliente cliente= banco.ListaCLientes.Find(c=>c.Equals(new Cliente(dni)));
            txtDni.Text = cliente.DNI;
            txtNombre.Text = cliente.Nombre;
            txtDireccion.Text = cliente.Direccion;
            txtEdad.Text = cliente.Edad.ToString();
            txtTelefono.Text = cliente.Telefono.ToString();
            txtCuenta.Text = cliente.NumCuenta.ToString();
        }
    }
}
