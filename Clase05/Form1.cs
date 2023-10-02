using Modelos;
using Negocio;

namespace Clase05
{
    public partial class Form1 : Form
    {
        List<Materia> materiaList = new List<Materia>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materiaList = NMateria.Get();
            materiaBindingSource.DataSource = materiaList;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Materia materiaSelected = (Materia)materiaBindingSource.Current;
                if(materiaSelected != null)
                {
                    textBox1.Text = materiaSelected.descripcion.ToString();
                    label1.Text = materiaSelected.id.ToString();
                }
                else { textBox1.Text = string.Empty; label1.Text = string.Empty; }
            }
            catch(Exception)
            {
                throw;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox
                .Show("¿Desea borrar el elemento?",
                "Confirmacion",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                int id = int.Parse(label1.Text);
                NMateria.Delete(id);
                materiaList = NMateria.Get();
                materiaBindingSource.DataSource = materiaList;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NMateria.Insert(textBox2.Text);
            materiaList = NMateria.Get();
            materiaBindingSource.DataSource = materiaList;
        }
    }
}