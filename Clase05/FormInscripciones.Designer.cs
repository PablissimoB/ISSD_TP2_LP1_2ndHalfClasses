namespace Presentacion
{
    partial class FormInscripciones
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
            components = new System.ComponentModel.Container();
            comboBox1 = new ComboBox();
            materiaBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            alumnoBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            comboBox3 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            button2 = new Button();
            label4 = new Label();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            NombreMateria = new DataGridViewTextBoxColumn();
            NombreCompletoAlumno = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)materiaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DataSource = materiaBindingSource;
            comboBox1.DisplayMember = "descripcion";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(45, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 38);
            comboBox1.TabIndex = 0;
            comboBox1.ValueMember = "id";
            // 
            // materiaBindingSource
            // 
            materiaBindingSource.DataSource = typeof(Modelos.Materia);
            // 
            // comboBox2
            // 
            comboBox2.DataSource = alumnoBindingSource;
            comboBox2.DisplayMember = "apellido";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(309, 128);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(325, 38);
            comboBox2.TabIndex = 1;
            comboBox2.ValueMember = "id";
            // 
            // alumnoBindingSource
            // 
            alumnoBindingSource.DataSource = typeof(Modelos.Alumno);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(45, 51);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 35);
            dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 92);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 3;
            label1.Text = "Materias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 95);
            label2.Name = "label2";
            label2.Size = new Size(95, 30);
            label2.TabIndex = 4;
            label2.Text = "Alumnos";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(683, 128);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(212, 38);
            comboBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(683, 92);
            label3.Name = "label3";
            label3.Size = new Size(76, 30);
            label3.TabIndex = 6;
            label3.Text = "Turnos";
            // 
            // button1
            // 
            button1.Location = new Point(924, 82);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 7;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, NombreMateria, NombreCompletoAlumno, fechaDataGridViewTextBoxColumn, turnoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(32, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(958, 262);
            dataGridView1.TabIndex = 8;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Modelos.Inscripcion);
            // 
            // button2
            // 
            button2.Location = new Point(924, 137);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 9;
            button2.Text = "Baja";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 184);
            label4.Name = "label4";
            label4.Size = new Size(68, 30);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 9;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 175;
            // 
            // NombreMateria
            // 
            NombreMateria.DataPropertyName = "NombreMateria";
            NombreMateria.HeaderText = "NombreMateria";
            NombreMateria.MinimumWidth = 9;
            NombreMateria.Name = "NombreMateria";
            NombreMateria.ReadOnly = true;
            NombreMateria.Width = 175;
            // 
            // NombreCompletoAlumno
            // 
            NombreCompletoAlumno.DataPropertyName = "NombreCompletoAlumno";
            NombreCompletoAlumno.HeaderText = "NombreCompletoAlumno";
            NombreCompletoAlumno.MinimumWidth = 9;
            NombreCompletoAlumno.Name = "NombreCompletoAlumno";
            NombreCompletoAlumno.ReadOnly = true;
            NombreCompletoAlumno.Width = 175;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            fechaDataGridViewTextBoxColumn.MinimumWidth = 9;
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.Width = 175;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            turnoDataGridViewTextBoxColumn.DataPropertyName = "turno";
            turnoDataGridViewTextBoxColumn.HeaderText = "turno";
            turnoDataGridViewTextBoxColumn.MinimumWidth = 9;
            turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            turnoDataGridViewTextBoxColumn.Width = 175;
            // 
            // FormInscripciones
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 691);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "FormInscripciones";
            Text = "FormInscripciones";
            Load += FormInscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)materiaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox3;
        private Label label3;
        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private Button button2;
        private DataGridViewTextBoxColumn idEstudianteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private Label label4;
        private BindingSource materiaBindingSource;
        private BindingSource alumnoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NombreMateria;
        private DataGridViewTextBoxColumn NombreCompletoAlumno;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
    }
}