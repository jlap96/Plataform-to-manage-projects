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
    public partial class ModificarEmpleados : Form
    {
        public ModificarEmpleados()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textId.ReadOnly = true;
                textPerfil.ReadOnly = true;
                textId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textApt1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textApt2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textEstatus.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textPerfil.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {

                //Agregamos mensaje de error
                MessageBox.Show("Error al mostrar datos", "Estado de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarEmpleados_Load(object sender, EventArgs e)
        {
            cargarEmpleados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.ObtenerConexion();
            try
            {
                string actualizar = "UPDATE empleados SET NombreEmp=@nombre, ApPatEmp=@Ap1, ApMatEmp=@Ap2, Estatus=@estatus where NoEmpleados=@id";
                MySqlCommand update = new MySqlCommand(actualizar, conexion.ObtenerConexion());

                update.Parameters.AddWithValue("@id", textId.Text);
                update.Parameters.AddWithValue("@nombre", textNombre.Text);
                update.Parameters.AddWithValue("@Ap1", textApt1.Text);
                update.Parameters.AddWithValue("@Ap2", textApt2.Text);
                update.Parameters.AddWithValue("@estatus", textEstatus.Text);


                update.ExecuteNonQuery();
                conexion.ObtenerConexion().Close();

                MessageBox.Show("Datos actualizados", "Estado de conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarEmpleados();

            }
            catch (Exception g)
            {

                MessageBox.Show(g.Message, g.StackTrace);
            }
        }

        void cargarEmpleados()
        {
            conexion.ObtenerConexion();
            try
            {
                //Realizamos consulta a BD para obtener los datos de la tabla empleados
                MySqlCommand com = new MySqlCommand("select NoEmpleados, NombreEmp, ApPatEmp, ApMatEmp, Estatus, perfil_idperfil from empleados order by NoEmpleados asc", conexion.ObtenerConexion());
                MySqlDataAdapter da = new MySqlDataAdapter(com);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                //enlazamos los datos de la BD y la tabla con el datagridview y llenamos con datos el datagridview
                dataGridView1.DataSource = tabla;
                //Agregamos encabezado a cada columna
                dataGridView1.Columns["NoEmpleados"].HeaderText = "No EMPLEADO";
                dataGridView1.Columns["NombreEmp"].HeaderText = "NOMBRE";
                dataGridView1.Columns["ApPatEmp"].HeaderText = "APELLIDO PATERNO";
                dataGridView1.Columns["ApMatEmp"].HeaderText = "APELLIDO MATERNO";
                dataGridView1.Columns["Estatus"].HeaderText = "ESTATUS";
                dataGridView1.Columns["perfil_idperfil"].HeaderText = "PERFIL";
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
                string eliminar = "DELETE FROM empleados WHERE NoEmpleados= @id";
                MySqlCommand delete = new MySqlCommand(eliminar, conexion.ObtenerConexion());

                delete.Parameters.AddWithValue("@id", textId.Text);
                delete.ExecuteNonQuery();

                conexion.ObtenerConexion().Close();

                MessageBox.Show("Datos eliminados", "Estado de conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarEmpleados();
            }
            catch (Exception g)
            {

                MessageBox.Show(g.Message, g.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el empleado seleccionado?", "Estado de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                eliminar();

            }
            else
            {
                MessageBox.Show("Se cancelo la eliminación", "Eliminación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
