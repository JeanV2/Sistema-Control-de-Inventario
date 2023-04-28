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
    public partial class FrmListaProductosSolicituCompra : Form
    {
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Instancia al formulario principal para acceder a los controles que se encuentran en el
        /// </summary>
        FrmSolicitudCompra frmSolicitud = (FrmSolicitudCompra)Application.OpenForms["FrmSolicitudCompra"];
        //------------------------------------------------------------------------------------------
        public FrmListaProductosSolicituCompra()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // METODO PASAR DATOS NO CAMBIAR
            if (e.RowIndex != -1)
            {
                int fila = e.RowIndex;

                frmSolicitud.TxtCodigoProd.Text = DgvListaProductos.Rows[fila].Cells[0].Value.ToString();
                this.Close();
            }
        }
    }
}
