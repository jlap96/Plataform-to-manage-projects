namespace DSPRN3U2JUAP
{
    partial class Incio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprobarConexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyectosToolStripMenuItem,
            this.conexionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verEmpleadosToolStripMenuItem,
            this.verProyectosToolStripMenuItem,
            this.asignarProyectoToolStripMenuItem});
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // verEmpleadosToolStripMenuItem
            // 
            this.verEmpleadosToolStripMenuItem.Name = "verEmpleadosToolStripMenuItem";
            this.verEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.verEmpleadosToolStripMenuItem.Text = "Ver Empleados";
            this.verEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.verEmpleadosToolStripMenuItem_Click);
            // 
            // verProyectosToolStripMenuItem
            // 
            this.verProyectosToolStripMenuItem.Name = "verProyectosToolStripMenuItem";
            this.verProyectosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.verProyectosToolStripMenuItem.Text = "Ver proyectos";
            this.verProyectosToolStripMenuItem.Click += new System.EventHandler(this.verProyectosToolStripMenuItem_Click);
            // 
            // asignarProyectoToolStripMenuItem
            // 
            this.asignarProyectoToolStripMenuItem.Name = "asignarProyectoToolStripMenuItem";
            this.asignarProyectoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.asignarProyectoToolStripMenuItem.Text = "Asignar proyecto";
            this.asignarProyectoToolStripMenuItem.Click += new System.EventHandler(this.asignarProyectoToolStripMenuItem_Click);
            // 
            // conexionToolStripMenuItem
            // 
            this.conexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprobarConexionToolStripMenuItem});
            this.conexionToolStripMenuItem.Name = "conexionToolStripMenuItem";
            this.conexionToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.conexionToolStripMenuItem.Text = "Conexion";
            // 
            // comprobarConexionToolStripMenuItem
            // 
            this.comprobarConexionToolStripMenuItem.Name = "comprobarConexionToolStripMenuItem";
            this.comprobarConexionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.comprobarConexionToolStripMenuItem.Text = "Comprobar conexion";
            this.comprobarConexionToolStripMenuItem.Click += new System.EventHandler(this.comprobarConexionToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(247, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO";
            // 
            // Incio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Incio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem proyectosToolStripMenuItem;
        private ToolStripMenuItem verEmpleadosToolStripMenuItem;
        private ToolStripMenuItem verProyectosToolStripMenuItem;
        private ToolStripMenuItem asignarProyectoToolStripMenuItem;
        private ToolStripMenuItem conexionToolStripMenuItem;
        private ToolStripMenuItem comprobarConexionToolStripMenuItem;
        private Label label1;
    }
}