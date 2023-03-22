namespace DSPRN3U2JUAP
{
    partial class ModificarEmpleados
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            textId = new TextBox();
            textNombre = new TextBox();
            textApt1 = new TextBox();
            textApt2 = new TextBox();
            textEstatus = new TextBox();
            label6 = new Label();
            textPerfil = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(809, 277);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 321);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "No. Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 367);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 412);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 3;
            label3.Text = "Apellido paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 460);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 4;
            label4.Text = "Apellido materno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 505);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 5;
            label5.Text = "Estatus";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(757, 326);
            button1.Name = "button1";
            button1.Size = new Size(117, 57);
            button1.TabIndex = 6;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(757, 473);
            button2.Name = "button2";
            button2.Size = new Size(117, 52);
            button2.TabIndex = 7;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textId
            // 
            textId.Location = new Point(251, 321);
            textId.Name = "textId";
            textId.Size = new Size(208, 27);
            textId.TabIndex = 8;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(251, 360);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(208, 27);
            textNombre.TabIndex = 9;
            // 
            // textApt1
            // 
            textApt1.Location = new Point(251, 409);
            textApt1.Name = "textApt1";
            textApt1.Size = new Size(208, 27);
            textApt1.TabIndex = 10;
            // 
            // textApt2
            // 
            textApt2.Location = new Point(251, 453);
            textApt2.Name = "textApt2";
            textApt2.Size = new Size(208, 27);
            textApt2.TabIndex = 11;
            // 
            // textEstatus
            // 
            textEstatus.Location = new Point(251, 498);
            textEstatus.Name = "textEstatus";
            textEstatus.Size = new Size(208, 27);
            textEstatus.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 553);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 13;
            label6.Text = "Perfil";
            // 
            // textPerfil
            // 
            textPerfil.Location = new Point(251, 546);
            textPerfil.Name = "textPerfil";
            textPerfil.Size = new Size(208, 27);
            textPerfil.TabIndex = 14;
            // 
            // ModificarEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(949, 603);
            Controls.Add(textPerfil);
            Controls.Add(label6);
            Controls.Add(textEstatus);
            Controls.Add(textApt2);
            Controls.Add(textApt1);
            Controls.Add(textNombre);
            Controls.Add(textId);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ModificarEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarEmpleados";
            Load += ModificarEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private TextBox textId;
        private TextBox textNombre;
        private TextBox textApt1;
        private TextBox textApt2;
        private TextBox textEstatus;
        private Label label6;
        private TextBox textPerfil;
    }
}