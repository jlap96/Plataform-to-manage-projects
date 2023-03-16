using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSPRN3U2JUAP
{
    public partial class Incio : Form
    {
        public Incio()
        {
            InitializeComponent();
        }

        private void comprobarConexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            comConexion venConexion = new comConexion();
            venConexion.ShowDialog();
        }

        private void verEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asignarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asignar venAsignar = new asignar();
            venAsignar.ShowDialog();
        }

        private void verProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarProyectos venProyectos = new MostrarProyectos();
            venProyectos.ShowDialog();
        }
    }
}
