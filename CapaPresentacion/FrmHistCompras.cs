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
    public partial class FrmHistCompras : Form
    {
        public FrmHistCompras()
        {
            InitializeComponent();
        }

        private void FrmHistCompras_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        public void CargarDt()
        {

        }
        private void FrmHistCompras_Load(object sender, EventArgs e)
        {
            DtpFecha1.CustomFormat = DateTime.Now.ToString("yyyy-MM-dd");
            DtpFecha2.CustomFormat = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1,DtpFecha1.Value.ToString("yyyy-MM-dd"), DtpFecha2.Value.ToString("yyyy-MM-dd"));
        }
    }
}
