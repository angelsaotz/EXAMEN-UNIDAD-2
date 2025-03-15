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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("insert into Usuarios (APATERNO,AMATERNO,NOMBRE,TELEFONO,CORREO) values('" + tbApat.Text + "','" +
                tbAmat.Text + "','" + tbNombre.Text + "','" + mtbTelefono.Text.Replace("(", "").Replace(")", "").Replace("-", "") + "','" + tbCorreo.Text + "')");
            if (f == true)
            {
                MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
   
