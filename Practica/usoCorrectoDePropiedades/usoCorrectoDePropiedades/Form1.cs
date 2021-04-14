using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usoCorrectoDePropiedades
{
    public partial class Form1 : Form
    {
        // Atributos de clase
        Usuario usuario;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtNombre.Text, txtApellido.Text, txtDni.Text, txtEmail.Text, txtDireccion.Text);

            MessageBox.Show($"El usuario ha sido registrado con éxito: {usuario.Nombre} {usuario.Apellido} {usuario.Dni} {usuario.Email} {usuario.Direccion}");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            usuario.Direccion = txtDireccion.Text;

            MessageBox.Show($"Se actualizó la dirección: {usuario.Nombre} {usuario.Apellido} {usuario.Dni} {usuario.Email} {usuario.Direccion}");
        }
    }
}
