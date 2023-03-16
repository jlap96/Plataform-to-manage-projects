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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mostrarProy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(603, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // mostrarProy
            // 
            this.mostrarProy.AutoEllipsis = true;
            this.mostrarProy.ForeColor = System.Drawing.SystemColors.Desktop;
            this.mostrarProy.Location = new System.Drawing.Point(295, 65);
            this.mostrarProy.Name = "mostrarProy";
            this.mostrarProy.Size = new System.Drawing.Size(91, 30);
            this.mostrarProy.TabIndex = 1;
            this.mostrarProy.Text = "MOSTRAR";
            this.mostrarProy.UseVisualStyleBackColor = true;
            this.mostrarProy.Click += new System.EventHandler(this.mostrarProy_Click);
            // 
            // MostrarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.mostrarProy);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MostrarProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button mostrarProy;
    }
}