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
    public partial class ReporteEntrega : Form
    {
        public ReporteEntrega()
        {
            InitializeComponent();
        }
        FrmLogin frm = (FrmLogin)Application.OpenForms["FrmLogin"];
        private void ReporteEntrega_Load(object sender, EventArgs e)
        {
            this.solicitudEntregaReportTableAdapter.Connection.ConnectionString = frm.ObtenerConexionReporte();
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.SolicitudEntregaReport' Puede moverla o quitarla según sea necesario.
            this.solicitudEntregaReportTableAdapter.Fill(this.dataSet1.SolicitudEntregaReport,FrmHistInsumos.CodigoPasar);

            this.reportViewer1.RefreshReport();
        }
    }
}
