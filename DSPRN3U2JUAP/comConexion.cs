namespace DSPRN3U2JUAP
{
    public partial class comConexion : Form
    {
        public comConexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.ObtenerConexion();
                MessageBox.Show("Conexion exitosa", "Estado de conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Conexion exitosa");
            }
            catch
            {
                MessageBox.Show("Error de conexion", "Estado de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}