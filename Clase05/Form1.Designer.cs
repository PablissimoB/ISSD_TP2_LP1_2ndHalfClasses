namespace Clase05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materiaBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materiaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = materiaBindingSource;
            dataGridView1.Location = new Point(11, 63);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(427, 130);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 9;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            descripcionDataGridViewTextBoxColumn.MinimumWidth = 9;
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.Width = 250;
            // 
            // materiaBindingSource
            // 
            materiaBindingSource.DataSource = typeof(Modelos.Materia);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(564, 77);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(467, 63);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(467, 85);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripcion";
            // 
            // button1
            // 
            button1.Location = new Point(468, 116);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(468, 145);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Baja";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(363, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Alta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(345, 23);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 274);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)materiaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource materiaBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
    }
}