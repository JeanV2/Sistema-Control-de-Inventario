using CapaEntidades;
using CapaNegocios;
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
        public static String codpasar;
        NegocioSolCompra  NCompra= new NegocioSolCompra();
        List<TbSolicitudCompra> SolicitudesCompra;
        public FrmHistCompras()
        {
            InitializeComponent();
        }
        public void CargarDt(List<TbSolicitudCompra>list)
        {
            foreach (TbSolicitudCompra Lis in list)
            {
                int row = DgvListaProductos.Rows.Add();
                DgvListaProductos.Rows[row].Cells[0].Value = Lis.IdSolicitudCompra;
                DgvListaProductos.Rows[row].Cells[1].Value = Lis.TbColaborador.NombreColaborador;
                DgvListaProductos.Rows[row].Cells[2].Value = Lis.MontoSolicitudCompra;
                DgvListaProductos.Rows[row].Cells[3].Value = Lis.FechaSolicitudCompra;
            }
        }
        private void FrmHistCompras_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
       
        private void FrmHistCompras_Load(object sender, EventArgs e)
        {
            SolicitudesCompra = NCompra.ListaSolicitudes();
            CargarDt(SolicitudesCompra);
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            List<TbSolicitudCompra> listaAux = SolicitudesCompra.Where(x => x.FechaSolicitudCompra >= DtpFecha1.Value && x.FechaSolicitudCompra <= DtpFecha2.Value).ToList(); ;
            if (listaAux.Count > 0)
            {
                DgvListaProductos.Rows.Clear();
                CargarDt(listaAux);
            }
            else
            {
                DgvListaProductos.Rows.Clear();
                CargarDt(SolicitudesCompra);
                MessageBox.Show("No se encontraron solicitudes entre el rango de fechas ingresado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string id = DgvListaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                codpasar= id;
                ReporteCompra Frm = new ReporteCompra();
                Frm.ShowDialog();
            }
        }
    }
}
