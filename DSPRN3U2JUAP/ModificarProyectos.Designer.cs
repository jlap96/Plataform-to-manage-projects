namespace DSPRN3U2JUAP
{
    partial class ModificarProyectos
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
            textDepartamento = new TextBox();
            label6 = new Label();
            textEstatus = new TextBox();
            textFechaFin = new TextBox();
            textFechaInicio = new TextBox();
            textNombre = new TextBox();
            textId = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            maskedFechaFinReal = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textDepartamento
            // 
            textDepartamento.Location = new Point(262, 592);
            textDepartamento.Name = "textDepartamento";
            textDepartamento.Size = new Size(208, 27);
            textDepartamento.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 599);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 28;
            label6.Text = "Departamento";
            // 
            // textEstatus
            // 
            textEstatus.Location = new Point(262, 538);
            textEstatus.Name = "textEstatus";
            textEstatus.Size = new Size(208, 27);
            textEstatus.TabIndex = 27;
            // 
            // textFechaFin
            // 
            textFechaFin.Location = new Point(262, 445);
            textFechaFin.Name = "textFechaFin";
            textFechaFin.Size = new Size(208, 27);
            textFechaFin.TabIndex = 26;
            // 
            // textFechaInicio
            // 
            textFechaInicio.Location = new Point(262, 401);
            textFechaInicio.Name = "textFechaInicio";
            textFechaInicio.Size = new Size(208, 27);
            textFechaInicio.TabIndex = 25;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(262, 352);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(208, 27);
            textNombre.TabIndex = 24;
            // 
            // textId
            // 
            textId.Location = new Point(262, 313);
            textId.Name = "textId";
            textId.Size = new Size(208, 27);
            textId.TabIndex = 23;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(886, 567);
            button2.Name = "button2";
            button2.Size = new Size(117, 52);
            button2.TabIndex = 22;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(886, 313);
            button1.Name = "button1";
            button1.Size = new Size(117, 57);
            button1.TabIndex = 21;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 545);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 20;
            label5.Text = "Estatus";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 452);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 19;
            label4.Text = "Fecha fin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 404);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 18;
            label3.Text = "Fecha inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 359);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 17;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 313);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 16;
            label1.Text = "Folio";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(76, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(927, 277);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 494);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 30;
            label7.Text = "Fecha fin real";
            // 
            // maskedFechaFinReal
            // 
            maskedFechaFinReal.Location = new Point(262, 491);
            maskedFechaFinReal.Mask = "0000/00/00";
            maskedFechaFinReal.Name = "maskedFechaFinReal";
            maskedFechaFinReal.Size = new Size(208, 27);
            maskedFechaFinReal.TabIndex = 32;
            maskedFechaFinReal.ValidatingType = typeof(DateTime);
            // 
            // ModificarProyectos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1097, 702);
            Controls.Add(maskedFechaFinReal);
            Controls.Add(label7);
            Controls.Add(textDepartamento);
            Controls.Add(label6);
            Controls.Add(textEstatus);
            Controls.Add(textFechaFin);
            Controls.Add(textFechaInicio);
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
            Name = "ModificarProyectos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarProyectos";
            Load += ModificarProyectos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDepartamento;
        private Label label6;
        private TextBox textEstatus;
        private TextBox textFechaFin;
        private TextBox textFechaInicio;
        private TextBox textNombre;
        private TextBox textId;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label7;
        private MaskedTextBox maskedFechaFinReal;
    }
}