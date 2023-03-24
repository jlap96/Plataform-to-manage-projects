using MySql.Data.MySqlClient;
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
    public partial class ModificarProyectos : Form
    {
        public ModificarProyectos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.ObtenerConexion();
            try
            {
                string actualizar = "UPDATE proyectos SET Nombre=@nombre, FechaInicio=@FechaIn, FechaFin=@FechaFin, Estatus=@estatus, FechaFinReal=@fin where FolioProy=@id";
                MySqlCommand update = new MySqlCommand(actualizar, conexion.ObtenerConexion());

                update.Parameters.AddWithValue("@id", textId.Text);
                update.Parameters.AddWithValue("@nombre", textNombre.Text);
                update.Parameters.AddWithValue("@FechaIn", textFechaInicio.Text);
                update.Parameters.AddWithValue("@FechaFin", textFechaFin.Text);
                update.Parameters.AddWithValue("@estatus", textEstatus.Text);
                update.Parameters.AddWithValue("@fin", maskedFechaFinReal.Text);


                update.ExecuteNonQuery();
                conexion.ObtenerConexion().Close();

                MessageBox.Show("Datos actualizados", "Estado de conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarProyectos();

            }
            catch (Exception g)
            {

                MessageBox.Show(g.Message, g.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el proyecto seleccionado?", "Estado de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                eliminar();

            }
            else
            {
                MessageBox.Show("Se cancelo la eliminación", "Eliminación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        void cargarProyectos()
        {
            conexion.ObtenerConexion();
            try
            {
                //Realizamos consulta a BD para obtener los datos de la tabla proyectos
                MySqlCommand com = new MySqlCommand("select FolioProy, Nombre, FechaInicio, FechaFin, Estatus, departamento_iddepartamento, FechaFinReal from proyectos order by FolioProy asc", conexion.ObtenerConexion());
                MySqlDataAdapter da = new MySqlDataAdapter(com);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                //enlazamos los datos de la BD y la tabla con el datagridview y llenamos con datos el datagridview
                dataGridView1.DataSource = tabla;
                //Agregamos encabezado a cada columna
                dataGridView1.Columns["FolioProy"].HeaderText = "FOLIO";
                dataGridView1.Columns["Nombre"].HeaderText = "NOMBRE";
                dataGridView1.Columns["FechaInicio"].HeaderText = "FECHA INICIO";
                dataGridView1.Columns["FechaFin"].HeaderText = "FECHA FIN";
                dataGridView1.Columns["Estatus"].HeaderText = "ESTATUS";
                dataGridView1.Columns["departamento_iddepartamento"].HeaderText = "DEPARTAMENTO";
                dataGridView1.Columns["FechaFinReal"].HeaderText = "FECHA FIN REAL";
                dataGridView1.AllowUserToAddRows = false;
                //Cerramos la conexion 
                conexion.ObtenerConexion().Close();
            }
            catch
            {
                //Agregamos mensaje de error
                MessageBox.Show("Error al mostrar datos", "Estado de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void eliminar()
        {

            conexion.ObtenerConexion();

            try
            {
                string eliminar = "DELETE FROM proyectos WHERE FolioProy= @id";
                MySqlCommand delete = new MySqlCommand(eliminar, conexion.ObtenerConexion());

                delete.Parameters.AddWithValue("@id", textId.Text);
                delete.ExecuteNonQuery();

                conexion.ObtenerConexion().Close();

                MessageBox.Show("Datos eliminados", "Estado de conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarProyectos();
            }
            catch (Exception g)
            {

                MessageBox.Show(g.Message, g.StackTrace);
            }
        }

        private void ModificarProyectos_Load(object sender, EventArgs e)
        {
            cargarProyectos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textId.ReadOnly = true;
                textDepartamento.ReadOnly = true;
                textId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textFechaInicio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textFechaFin.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textEstatus.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textDepartamento.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                maskedFechaFinReal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {

                //Agregamos mensaje de error
                MessageBox.Show("Error al mostrar datos", "Estado de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
