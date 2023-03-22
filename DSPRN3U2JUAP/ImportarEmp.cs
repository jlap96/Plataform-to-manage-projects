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
using System.IO;

namespace DSPRN3U2JUAP
{
    public partial class ImportarEmp : Form
    {
        public ImportarEmp()
        {
            InitializeComponent();
        }
        //Creamos el DataTable
        DataTable tabla = new DataTable();
        
        private void Importar_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agregamos las columnas que necesitaremos al DataTable
            tabla.Columns.Add("No Empleados", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Apellido paterno", typeof(string));
            tabla.Columns.Add("Apellido materno", typeof(string));
            tabla.Columns.Add("Estatus", typeof(char));
            tabla.Columns.Add("Perfil", typeof(int));
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
                MySqlCommand guardar = new MySqlCommand("insert into empleados(NoEmpleados,NombreEmp,ApPatEmp,ApMatEmp,Estatus,perfil_idperfil) values (@empleado,@nombre,@apellido,@apellido2,@estatus,@perfil)", conexion.ObtenerConexion());
                //Rrecorremos el dataGridVies
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    
                //Asignamos los valores de la tabla al "values" de nuestro query guardar.
                
                        guardar.Parameters.Clear();
                        guardar.Parameters.AddWithValue("@empleado", row.Cells["No Empleados"].Value);
                        guardar.Parameters.AddWithValue("@nombre", row.Cells["Nombre"].Value);
                        guardar.Parameters.AddWithValue("@apellido", row.Cells["Apellido paterno"].Value);
                        guardar.Parameters.AddWithValue("@apellido2", row.Cells["Apellido materno"].Value);
                        guardar.Parameters.AddWithValue("@estatus", row.Cells["Estatus"].Value);
                        guardar.Parameters.AddWithValue("@perfil", row.Cells["Perfil"].Value);

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
