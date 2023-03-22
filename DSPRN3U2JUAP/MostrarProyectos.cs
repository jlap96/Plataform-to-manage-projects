using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DSPRN3U2JUAP
{
    public partial class MostrarProyectos : Form
    {
        public MostrarProyectos()
        {
            InitializeComponent();
        }

        private void mostrarProy_Click(object sender, EventArgs e)
        {
            conexion.ObtenerConexion();
            try
            {
                //Realizamos consulta a BD para obtener los datos de la tabla asignar proyecto
                MySqlCommand com = new MySqlCommand("select proyectos_FolioProy, empleados_NoEmpleados, asignado, comentario from asignarproyecto order by proyectos_FolioProy, empleados_NoEmpleados asc", conexion.ObtenerConexion());
                MySqlDataAdapter da = new MySqlDataAdapter(com);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                //enlazamos los datos de la BD y la tabla con el datagridview y llenamos con datos el datagridview
                dataGridView1.DataSource = tabla;
                //Agregamos encabezado a cada columna
                dataGridView1.Columns["proyectos_FolioProy"].HeaderText = "FOLIO";
                dataGridView1.Columns["empleados_NoEmpleados"].HeaderText = "No EMPLEADO";
                dataGridView1.Columns["asignado"].HeaderText = "ASIGNADO";
                dataGridView1.Columns["comentario"].HeaderText = "COMENTARIO";
                //Cerramos la conexion 
                conexion.ObtenerConexion().Close();
            }
            catch
            {
                //Agregamos mensaje de error
                MessageBox.Show("Error al mostrar datos", "Estado de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
