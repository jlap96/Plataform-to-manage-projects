using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class verProyectos : Form
    {
        public verProyectos()
        {
            InitializeComponent();
        }
        //Declaramos una variable de tipo DateTime para obtener la fecha del dia actual
        DateTime hoy = DateTime.Now;



        private void verProyectos_Load(object sender, EventArgs e)
        {
            //Cargamos los proyectos al DataGridView
            cargarProyectos();

            //Obtenemos la fecha actual del sistema
            textFecha.Text = hoy.ToShortDateString();
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
                dataGridView1.Columns["FechaFinReal"].HeaderText = "FECHA REAL DE FINALIZACION";
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Filtramos los resultados por el campo fecha fin real
            //A través de la propiedad DefaultView.RowFilter filtramos las filas que se van a mostrar
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = String.Format("convert(FechaFinReal, 'System.String') LIKE '%{0}%'", textFecha.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Validamos que existan registros en el dataGridView a importar
            if(dataGridView1.Rows.Count > 0)
            {
                //Abrimos el dialogo save
                SaveFileDialog guardar = new SaveFileDialog();
                //Filtramos por tipo de archivo a importar como PDF
                guardar.Filter = "PDF (*.pdf)|*.pdf";
                //Agregamos un nombre por defecto al archivo
                guardar.FileName = "Resultado proyectos.pdf";
                bool fileError = false;
                if(guardar.ShowDialog() == DialogResult.OK)
                {
                    //Validamos si el archivo existe y si se desea reemplazar
                    if(File.Exists(guardar.FileName))
                    {
                        try
                        {
                            File.Delete(guardar.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No se pudo guardar el archivo" + ex.Message);
                        }
                    }
                    if(!fileError)
                    {
                        //Agregamos al archivo las columnas del datagridview
                        try
                        {
                            PdfPTable pdfPTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfPTable.DefaultCell.Padding = 1;
                            pdfPTable.WidthPercentage = 100;
                            pdfPTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            //Recorremos las columnas del dataGridView y las agregamos a las cell del archivo pdf
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfPTable.AddCell(cell);
                            }
                            //recorremos las filas del dataGridView y las agregamos a las celdas del pdf
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfPTable.AddCell(cell.Value.ToString());
                                }
                            }

                            //Agregamos la clase FileStream para crear el archivo

                            using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfPTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            //Mensaje de éxito en la importación
                            MessageBox.Show("Exportación exitosa", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        //Mensaje de error al exportar
                        catch
                        {
                            MessageBox.Show("Error al exportar", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            //Sino existen registros que exportar mostramos el mensaje de error.
            else
            {
                MessageBox.Show("No hay datos para exportar", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
