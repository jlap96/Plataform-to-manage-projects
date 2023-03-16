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
    public partial class asignar : Form
    {

        public asignar()
        {
            InitializeComponent();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void asignar_Load(object sender, EventArgs e)
        {
            //Abrimos conexion a la base de datos
            conexion.ObtenerConexion();

            try
            {
                //Hacemos consulta folios de proyectos de la tabla proyectos
                MySqlCommand folio = new MySqlCommand("select FolioProy from proyectos", conexion.ObtenerConexion());
                //Leemos los datos
                MySqlDataReader rd = folio.ExecuteReader();
                //Agremos un ciclo while para indicar que mientras existan datos que leer se agreguen al comboBox1
                while (rd.Read())
                {
                    //Agremos los registros al comboBox1
                    comboBox1.Items.Add(rd["FolioProy"]);
                }
                //Cerramos la conexion
                conexion.ObtenerConexion().Close();

                //Hacemos consulta de No de empleados de la tabla empleados y los ordenamos de forma ascendente
                MySqlCommand empleado = new MySqlCommand("select NoEmpleados from empleados order by NoEmpleados asc", conexion.ObtenerConexion());
                //Leemos los datos
                MySqlDataReader registro = empleado.ExecuteReader();
                //Agremos un ciclo while para indicar que mientras existan datos que leer se agreguen al comboBox 2
                while (registro.Read())
                {
                    //Agregamos los registros al comboBox2
                    comboBox2.Items.Add(registro["NoEmpleados"]); 
                }
                //Cerramos la conexion
                conexion.ObtenerConexion().Close();
            }
            catch (Exception c)
            {

                MessageBox.Show(c.Message, c.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrimos conexion a BD
            conexion.ObtenerConexion();

            try
            {
                //Obtenemos las llaves foraneas que serviran para insertar un nuevo registro en la tabla asignarproyecto
                string obtenerPerfil = "select perfil_idperfil from empleados where NoEmpleados ='" + comboBox2.SelectedItem + "'";
                string obtenerDpto = "select departamento_iddepartamento from proyectos where FolioProy ='" + comboBox1.SelectedItem + "'";

                //Se crea el comando de consulta a la base de datos
                MySqlCommand perfil = new MySqlCommand(obtenerPerfil, conexion.ObtenerConexion());
                //Convertimos el resultado de la consulta a tipo de dato int para poder realizar el insert a la tabla asignarproyecto
                int convertirPerfil = Convert.ToInt32(perfil.ExecuteScalar());

                MySqlCommand departamento = new MySqlCommand(obtenerDpto, conexion.ObtenerConexion());
                int convertirDepto = Convert.ToInt32(departamento.ExecuteScalar());

                //Se crea el comando de insertar a la base de datos
                MySqlCommand insertar = new MySqlCommand("insert into asignarproyecto (empleados_NoEmpleados, empleados_perfil_idperfil, proyectos_FolioProy,proyectos_departamento_iddepartamento,asignado,comentario)" +
                    "values ('" + comboBox2.SelectedItem + "', '" + convertirPerfil + "','" + comboBox1.SelectedItem + "','" + convertirDepto + "','" + 1 + "', '" + comentarios.Text + "')", conexion.ObtenerConexion());

                //Ejecutamos el comando 
                insertar.ExecuteNonQuery();
                //Cerramos la conexion
                conexion.ObtenerConexion().Close();
                //Mostramos mensaje
                MessageBox.Show("Asignacion guardada", "Estado de asignacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                //Mostramos mensaje de error
                MessageBox.Show("Error al guardar. Compruebe formulario","Estado de asignacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        
        }

        
    }
}
