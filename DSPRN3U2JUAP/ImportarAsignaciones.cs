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
using MySql.Data.MySqlClient;

namespace DSPRN3U2JUAP
{
    public partial class ImportarAsignaciones : Form
    {
        public ImportarAsignaciones()
        {
            InitializeComponent();
        }
        //Creamos el DataTable
        DataTable tabla = new DataTable();
        private void ImportarAsignaciones_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agregamos las columnas que necesitaremos al DataTable
            tabla.Columns.Add("Empleado", typeof(int));
            tabla.Columns.Add("Perfil", typeof(int));
            tabla.Columns.Add("FolioProy", typeof(int));
            tabla.Columns.Add("Departamento", typeof(int));
            tabla.Columns.Add("Asignado", typeof(int));
            tabla.Columns.Add("Comentario", typeof(string));
            //Enlazamos los datos de la tabla al dataGridView
            dataGridView1.DataSource = tabla;

            //Abrimos el dialogo para leer el archivo txt
            OpenFileDialog d = new OpenFileDialog();
            //Agregamos un titulo a la ventana
            d.Title = "Importar archivo (.txt)";
            //Filtramos el tipo de archivo a txt
            d.Filter = "Txt | *.txt";

            if (d.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(d.FileName);

            }

            //Leemos el archivo txt y lo agregamos al dataGridView
            string[] lineas = File.ReadAllLines(d.FileName);
            string[] values;

            for (int i = 0; i < lineas.Length; i++)
            {
                values = lineas[i].ToString().Split('/');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                tabla.Rows.Add(row);
                dataGridView1.AllowUserToAddRows = false; //No permitimos que el usuario agregue nuevos valores en el dataGridVies
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.ObtenerConexion();
            try
            {
                //Creamos el comando para insertar los valores a la tabla
                MySqlCommand guardar = new MySqlCommand("insert into asignarproyecto(empleados_NoEmpleados,empleados_perfil_idperfil,proyectos_FolioProy,proyectos_departamento_iddepartamento,asignado,comentario) values (@empleado,@perfil,@proyecto,@departamento,@asignado,@comentario)", conexion.ObtenerConexion());
                //Rrecorremos el dataGridVies
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    //Asignamos los valores de la tabla al "values" de nuestro query guardar
                    guardar.Parameters.Clear();
                    guardar.Parameters.AddWithValue("@empleado", row.Cells["Empleado"].Value);
                    guardar.Parameters.AddWithValue("@perfil", row.Cells["Perfil"].Value);
                    guardar.Parameters.AddWithValue("@proyecto", row.Cells["FolioProy"].Value);
                    guardar.Parameters.AddWithValue("@departamento", row.Cells["Departamento"].Value);
                    guardar.Parameters.AddWithValue("@asignado", row.Cells["Asignado"].Value);
                    guardar.Parameters.AddWithValue("@comentario", row.Cells["Comentario"].Value);

                    guardar.ExecuteNonQuery();

                }

                MessageBox.Show("Importacion exitosa", "Estado de importacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception F)
            {

                MessageBox.Show(F.Message, F.StackTrace);
            }
        }
    }
}
