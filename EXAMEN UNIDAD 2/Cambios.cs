using Practica_AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_UNIDAD_2
{
    public partial class Cambios : Form
    {
        public Cambios(string id, string nom, string ap, string am, string tel, string correo)
        {
            InitializeComponent();
            tbId.Text = id;
            tbNombre.Text = nom;
            tbApat.Text = ap;
            tbAmat.Text = am;
            tbTelefono.Text = tel;
            mtbCorreo.Text = correo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("delete from Usuarios where ID='" + tbId.Text + "'");
            if (f == true)
            {
                MessageBox.Show("Registro eiminado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error al eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butActualizar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("update Usuarios set APATERNO='" + tbApat.Text + "',AMATERNO='" +
                tbAmat.Text + "',NOMBRE='" + tbNombre.Text + "',TELEFONO='" + tbTelefono.Text.Replace("(", "").Replace(")", "").Replace("-", "") + "',CORREO='" + mtbCorreo.Text +
                "' where ID='" + tbId.Text + "'");
            if (f == true)
            {
                MessageBox.Show("Datos actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
