using Practica_AccesoADatos;
using System.Data;

namespace EXAMEN_UNIDAD_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aLTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta alta = new Alta();
            alta.Show();
            oPCIONESToolStripMenuItem.HideDropDown();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("Select ID as ID,APATERNO as [Apellido Paterno],AMATERNO as [Apellido Materno],NOMBRE as NOMBRE,TELEFONO as TELEFONO,CORREO as CORREO From Usuarios");

            if (ds != null)
            {
                dgvOpciones.DataSource = ds.Tables[0];
            }
        }

        private void dgvOpciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cambios cambios = new Cambios(
               dgvOpciones[0, e.RowIndex].Value.ToString(),
               dgvOpciones[3, e.RowIndex].Value.ToString(),
               dgvOpciones[1, e.RowIndex].Value.ToString(),
               dgvOpciones[2, e.RowIndex].Value.ToString(),
               dgvOpciones[4, e.RowIndex].Value.ToString(),
               dgvOpciones[5, e.RowIndex].Value.ToString()
               );
            cambios.Show();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvOpciones.Visible = true;
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("Select ID as ID, APATERNO as [Apellido Paterno], AMATERNO as [Apellido Materno], NOMBRE as NOMBRE, TELEFONO as TELEFONO, CORREO as CORREO From Usuarios");
            if (ds != null)
            {
                dgvOpciones.DataSource = ds.Tables[0];
            }
            oPCIONESToolStripMenuItem.HideDropDown();
        }

        private void cERRARTABLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvOpciones.Visible = false;
            oPCIONESToolStripMenuItem.HideDropDown();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("Select ID as ID, APATERNO as [Apellido Paterno], AMATERNO as [Apellido Materno], NOMBRE as Nombre, TELEFONO as Telefono, CORREO as Correo From Usuarios");
            if (ds != null)
            {
                dgvOpciones.DataSource = ds.Tables[0];
            }
        }
    }
}
