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
    public partial class FrmListaPresupuestos : Form
    {
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Instancia al formulario principal para acceder a los controles que se encuentran en el
        /// </summary>
        FrmPresupuesto frmPresupuesto = (FrmPresupuesto)Application.OpenForms["FrmPresupuesto"];
        //----------------------------------------------------------------------------------------------
        public FrmListaPresupuestos()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int Fila = e.RowIndex;

                 frmPresupuesto.TxtCodigoPresepuesto.Text = DgvListaProductos.Rows[Fila].Cells[0].Value.ToString();
                 frmPresupuesto.DtpFechaSolicitud.Value = Convert.ToDateTime( DgvListaProductos.Rows[Fila].Cells[1].Value.ToString());
                 frmPresupuesto.TxtMontuoProsupuesto.Text = DgvListaProductos.Rows[Fila].Cells[2].Value.ToString();

                frmPresupuesto.BtnEliminar.Visible = true;
                frmPresupuesto.BtnModificar.Visible = true;
                frmPresupuesto.BtnGuardarPresupuesto.Enabled = false;
                this.Close();
            }
        }
    }
}
