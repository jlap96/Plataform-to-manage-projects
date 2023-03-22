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

            //Obtenemos la cantidad de analistas
            string cantAnalista = "select count(*) from asignarproyecto where empleados_perfil_idperfil= 3 and proyectos_FolioProy ='" + comboBox1.SelectedItem + "'";
            
            //Obtenemos la cantidad de lideres
            string cantLider = "select count(*) from asignarproyecto where empleados_perfil_idperfil= 2 and proyectos_FolioProy ='" + comboBox1.SelectedItem + "'";
            
            //Obtenemos la cantidad de programadores
            string cantProgramadores = "select count(*) from asignarproyecto where empleados_perfil_idperfil= 1 and proyectos_FolioProy ='" + comboBox1.SelectedItem + "'";
            
            //Obtenemos el estatus de los empleados
            string estatusEmp = "select estatus from empleados where NoEmpleados = '" + comboBox2.SelectedItem + "'";
           
            //Obtenemos el estatus de FechaFin de la tabla proyectos
            string estatusFecha = "select Estatus from proyectos where FolioProy = '" + comboBox1.SelectedItem + "'";

            //Validamos si el empleado ya se encuentra registrado en el proyecto 
            string empleadosRegis = "select count(*) from asignarproyecto where empleados_NoEmpleados ='" + comboBox2.SelectedItem + "'";

            //Obtenemos el perfil de los empleados para realizar las validaciones
            string obtenerPerfil = "select perfil_idperfil from empleados where NoEmpleados ='" + comboBox2.SelectedItem + "'";

            //Se crean los comandos de consulta
            MySqlCommand Analista = new MySqlCommand(cantAnalista, conexion.ObtenerConexion());
            //Convertimos el resultado de la consulta a tipo de dato int
            int convertirAnalista = Convert.ToInt32(Analista.ExecuteScalar());
            
            MySqlCommand Lider = new MySqlCommand(cantLider, conexion.ObtenerConexion());
            //Convertimos el resultado de la consulta a tipo de dato int
            int convertirLider = Convert.ToInt32(Lider.ExecuteScalar());

            MySqlCommand Programadores = new MySqlCommand(cantProgramadores, conexion.ObtenerConexion());
            //Convertimos el resultado de la consulta a tipo de dato int
            int convertirProgramadores = Convert.ToInt32(Programadores.ExecuteScalar());

            MySqlCommand estatus = new MySqlCommand(estatusEmp, conexion.ObtenerConexion());
            //Convertimos el resultado de la consulta a tipo de dato char
            char convertirEstatus = Convert.ToChar(estatus.ExecuteScalar());

            MySqlCommand Fecha = new MySqlCommand(estatusFecha, conexion.ObtenerConexion());
            int convertirFecha = Convert.ToInt32(Fecha.ExecuteScalar());

            MySqlCommand empleadoAsig = new MySqlCommand(empleadosRegis, conexion.ObtenerConexion());
            //Convertimos el resultado de la consulta a tipo de dato int
            int convertirempleadosAsignados = Convert.ToInt32(empleadoAsig.ExecuteScalar());

            MySqlCommand perfil = new MySqlCommand(obtenerPerfil, conexion.ObtenerConexion());
            //Convertimos el resultado de la consulta a tipo de dato int para poder realizar el insert a la tabla asignarproyecto
            int convertirPerfil = Convert.ToInt32(perfil.ExecuteScalar());

            if (convertirFecha == 1 && convertirEstatus == 'A' && convertirempleadosAsignados <1)
            {
                if(convertirPerfil == 1 && convertirProgramadores <3)
                {
                    asignarEmp();
                }
                else if(convertirPerfil == 2 && convertirLider <1)
                {
                    asignarEmp();
                }
                else if(convertirPerfil == 3 && convertirAnalista<1)
                {
                    asignarEmp();
                }
                else
                {
                    MessageBox.Show("Limite de perfil para este proyecto", "Estado de asignacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            else
            {
                MessageBox.Show("Error en la asignacion de proyecto", "Estado de asignacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        void asignarEmp()
        {
            try
            {
                conexion.ObtenerConexion();
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
                catch(Exception j)
            {
                //Mostramos mensaje de error
                MessageBox.Show(j.Message, j.StackTrace);
            }
        }       
    }
}
