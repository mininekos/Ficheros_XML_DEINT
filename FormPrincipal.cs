using Ficheros_XML.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ficheros_XML
{
    public partial class Menu : Form
    {
        Banco banco;
        List<Cliente> listaCliente;
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarYEliminar formAgregar = new FormAgregarYEliminar(banco,"");
            formAgregar.btnAceptar.Text = "Añadir";
            formAgregar.Text = "Añadir nuevo cliente";
            formAgregar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormModificar formEliminar = new FormModificar(banco);
            formEliminar.Text = "Eliminar cliente";
            formEliminar.btnOpcion.Text = "Eliminar";
            formEliminar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificar formModificar = new FormModificar(banco);
            formModificar.Text = "Modificar cliente";
            formModificar.btnOpcion.Text = "Modificar";
            formModificar.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FormMostrar formMostrar = new FormMostrar(banco);
            formMostrar.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try  {
                leerXML();
            }
            catch(Exception ex) {

                listaCliente = new List<Cliente>();
                banco = new Banco(listaCliente);
            }
            
        }

        private void leerXML()
        {
            ;
            XmlSerializer serializer = new XmlSerializer(typeof(Banco));

            using (var stream = new FileStream("banco.xml", FileMode.Open))
            {
                 banco = (Banco)serializer.Deserialize(stream);
            }
            
        }

        public void escribirXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Banco));
            using (var stream = new FileStream("banco.xml", FileMode.Create))
            {
                serializer.Serialize(stream, banco);               
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            escribirXML();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(banco.ListaCLientes.Count().ToString());
        }
    }
}
