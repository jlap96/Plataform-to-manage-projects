namespace DSPRN3U2JUAP
{
    partial class MostrarProyectos
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
            dataGridView1 = new DataGridView();
            mostrarProy = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 175);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(689, 389);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // mostrarProy
            // 
            mostrarProy.AutoEllipsis = true;
            mostrarProy.ForeColor = SystemColors.Desktop;
            mostrarProy.Location = new Point(337, 87);
            mostrarProy.Margin = new Padding(3, 4, 3, 4);
            mostrarProy.Name = "mostrarProy";
            mostrarProy.Size = new Size(104, 40);
            mostrarProy.TabIndex = 1;
            mostrarProy.Text = "MOSTRAR";
            mostrarProy.UseVisualStyleBackColor = true;
            mostrarProy.Click += mostrarProy_Click;
            // 
            // MostrarProyectos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(758, 600);
            Controls.Add(mostrarProy);
            Controls.Add(dataGridView1);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MostrarProyectos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MostrarProyectos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button mostrarProy;
    }
}