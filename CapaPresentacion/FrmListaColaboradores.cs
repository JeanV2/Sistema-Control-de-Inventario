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
    public partial class FrmListaColaboradores : Form
    {
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Instancia al formulario principal para acceder a los controles que se encuentran en el
        /// </summary>
        FrmColaboradores frmcolaboradores = (FrmColaboradores)Application.OpenForms["FrmColaboradores"];
        //------------------------------------------------------------------------------------------
        public FrmListaColaboradores()
        {
            InitializeComponent();
        }

        private void DgvListaColaboradores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // METODO PASAR DATOS NO CAMBIAR
            if (e.RowIndex != -1)
            {
                int fila = e.RowIndex;

                frmcolaboradores.TxtCedula.Text = DgvListaColaboradores.Rows[fila].Cells[0].Value.ToString();
                frmcolaboradores.TxtNombre.Text = DgvListaColaboradores.Rows[fila].Cells[1].Value.ToString();
                frmcolaboradores.TxtApe1.Text = DgvListaColaboradores.Rows[fila].Cells[2].Value.ToString();
                frmcolaboradores.TxtApe2.Text = DgvListaColaboradores.Rows[fila].Cells[3].Value.ToString();
                frmcolaboradores.CbTipo.SelectedValue = DgvListaColaboradores.Rows[fila].Cells[4].Value.ToString();
                frmcolaboradores.TxtUsuario.Text = DgvListaColaboradores.Rows[fila].Cells[5].Value.ToString();
                frmcolaboradores.TxtContraseña.Text = DgvListaColaboradores.Rows[fila].Cells[6].Value.ToString();

                frmcolaboradores.BtnGuardarColaborador.Enabled = false;
                frmcolaboradores.BtnModificar.Visible = true;
                frmcolaboradores.BtnEliminar.Visible = true;
                this.Close();
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmListaColaboradores_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
