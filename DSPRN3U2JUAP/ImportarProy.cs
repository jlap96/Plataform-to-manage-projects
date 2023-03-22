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
    public partial class ImportarProy : Form
    {
        public ImportarProy()
        {
            InitializeComponent();
        }
        //Creamos el DataTable
        DataTable tabla = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            //Agregamos las columnas que necesitaremos al DataTable
            tabla.Columns.Add("FolioProy", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Fecha inicio", typeof(string));
            tabla.Columns.Add("Fecha fin", typeof(string));
            tabla.Columns.Add("Estatus", typeof(int));
            tabla.Columns.Add("Departamento", typeof(int));
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
            try
            {
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
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.ObtenerConexion();
            try
            {
                //Creamos el comando para insertar los valores a la tabla
                MySqlCommand guardar = new MySqlCommand("insert into proyectos(FolioProy,Nombre,FechaInicio,FechaFin,Estatus,departamento_iddepartamento) values (@folio,@nombre,@FechaInicio,@FechaFin,@estatus,@departamento)", conexion.ObtenerConexion());
                //Rrecorremos el dataGridVies
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    //Asignamos los valores de la tabla al "values" de nuestro query guardar
                    guardar.Parameters.Clear();
                    guardar.Parameters.AddWithValue("@folio", row.Cells["FolioProy"].Value);
                    guardar.Parameters.AddWithValue("@nombre", row.Cells["Nombre"].Value);
                    guardar.Parameters.AddWithValue("@FechaInicio", row.Cells["Fecha inicio"].Value);                 
                    guardar.Parameters.AddWithValue("@FechaFin", row.Cells["Fecha fin"].Value);                   
                    guardar.Parameters.AddWithValue("@estatus", row.Cells["Estatus"].Value);
                    guardar.Parameters.AddWithValue("@departamento", row.Cells["Departamento"].Value);

                    guardar.ExecuteNonQuery();

                }

                MessageBox.Show("Importacion exitosa", "Estado de importacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {

                MessageBox.Show(g.Message, g.StackTrace);
            }
        }
    }
}
