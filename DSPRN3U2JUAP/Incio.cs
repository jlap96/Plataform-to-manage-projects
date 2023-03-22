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

        private void importarProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportarProy venImportarProy = new ImportarProy();
            venImportarProy.ShowDialog();
        }

        private void importarArchivosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ImportarEmp venImportar = new ImportarEmp();
            venImportar.ShowDialog();
        }

        private void importarAsignacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportarAsignaciones venImportarAsig = new ImportarAsignaciones();
            venImportarAsig.ShowDialog();
        }

        private void Incio_Load(object sender, EventArgs e)
        {

        }

        private void modificarEliminarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarEmpleados venmodificarEmpleados = new ModificarEmpleados();
            venmodificarEmpleados.ShowDialog();
        }

        private void modificarEliminarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarProyectos venmodificarProyectos = new ModificarProyectos();
            venmodificarProyectos.ShowDialog();
        }
    }
}
