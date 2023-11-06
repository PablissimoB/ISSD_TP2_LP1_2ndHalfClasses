using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporte
{
    public partial class Inscripciones : Form
    {
        public Inscripciones()
        {
            InitializeComponent();
        }

        private void Inscripciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.GetAllInscripcionesTabla' Puede moverla o quitarla según sea necesario.
            this.getAllInscripcionesTablaTableAdapter.Fill(this.dataSet1.GetAllInscripcionesTabla);

            this.reportViewer1.RefreshReport();
        }
    }
}
