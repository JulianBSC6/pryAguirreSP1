using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryAguirreSP1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            StreamWriter swCrearArchivo = new StreamWriter("ArchivoPrueba", false);

            if( swCrearArchivo != null)
            {
                MessageBox.Show("Archivo creado");

            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            StreamWriter swManejoArchivo = new StreamWriter("ArchivoPrueba", false)

                try
                {
                    swManejoArchivo.WriteLine(txtDatos.Text);
                    swManejoArchivo.Close();
                    MessageBox.Show("Almacenado");
                    txtDatos.Text = "";
                    txtDatos.Focus();
                }
                catch (Exception)
                {
                MessageBox.Show("Fatal error");
                }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {

        }
    }
}
