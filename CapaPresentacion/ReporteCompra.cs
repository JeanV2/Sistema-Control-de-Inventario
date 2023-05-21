using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ReporteCompra : Form
    {
        
        public ReporteCompra()
        {
            InitializeComponent();
        }

        private void ReporteCompra_Load(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.SolicitudCompraReport' Puede moverla o quitarla según sea necesario.
            this.solicitudCompraReportTableAdapter.Fill(this.dataSet1.SolicitudCompraReport,FrmHistCompras.codpasar);
=======
>>>>>>> Stashed changes

            this.reportViewer1.RefreshReport();
        }
    }
}
