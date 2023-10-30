using Datos;
using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FormInscripciones : Form
    {
        List<Inscripcion> lista = new List<Inscripcion>();
        public FormInscripciones()
        {
            InitializeComponent();
        }
        private void CargarAlumnos()
        {
            List<Alumno> list = new List<Alumno>();
            list = NAlumno.Get();
            alumnoBindingSource.DataSource = list;
        }
        private void CargarMaterias()
        {
            List<Materia> list = new List<Materia>();
            list = NMateria.Get();
            materiaBindingSource.DataSource = list;
        }
        private void CargarTurnos()
        {
            comboBox3.DataSource = Enum.GetValues(typeof(Turnos))
            .Cast<int>()
            .Select(value => new
            {
                Text = Enum.GetName(typeof(Turnos), value),
                Value = value
            })
            .ToList();

            comboBox3.DisplayMember = "Text";
            comboBox3.ValueMember = "Value";

        }
        private void FormInscripciones_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
            CargarMaterias();
            CargarTurnos();
            lista = NInscripcion.Get();

            bindingSource1.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

            int idMateria = (int)comboBox1.SelectedValue;
            int idAlumno = (int)comboBox2.SelectedValue;
            int turno = (int)comboBox3.SelectedValue;

            NInscripcion.Insert(idMateria, idAlumno, turno, fecha);
            lista = NInscripcion.Get();
            bindingSource1.DataSource = lista;
            label4.Text = $"Inscripcion lista";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (lista.Count > 0)
                {
                    Inscripcion inscripcion = (Inscripcion)bindingSource1.Current;

                    if (inscripcion != null)
                    {
                        label5.Text = inscripcion.id.ToString();
                        comboBox1.SelectedItem = inscripcion.idMateria;
                        comboBox2.SelectedItem = inscripcion.idAlumno;
                        comboBox3.SelectedItem = inscripcion.turno;
                        dateTimePicker1.Text = inscripcion.fecha.ToString();
                    }
                    else { }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            int id = int.Parse(label5.Text);
            int idMateria = (int)comboBox1.SelectedValue;
            int idAlumno = (int)comboBox2.SelectedValue;
            int turno = (int)comboBox3.SelectedValue;
            NInscripcion.Update(idMateria, idAlumno, turno, fecha, id);
            lista = NInscripcion.Get();
            bindingSource1.DataSource = lista;
            label4.Text = $"Inscripcion lista";
        }
    }
}
