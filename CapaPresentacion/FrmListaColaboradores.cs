using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

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

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            //Realizamos los tipos de busqueda de los colaboradores haciendo un filtro 
            IEnumerable<TbColaborador> ListAux= new List<TbColaborador>();
            if (TxtCodigo.Text!=string.Empty)
            {
                //ListAux= listaColabo
            }
        }

        private void FrmListaColaboradores_Load(object sender, EventArgs e)
        {

        }
        private void CargarCambios(List<TbColaborador> colaboradores)
        {
            DgvListaColaboradores.Rows.Clear();
            foreach (TbColaborador Colabo in colaboradores)
            {
                int nr = DgvListaColaboradores.Rows.Add();
                DgvListaColaboradores.Rows[nr].Cells[0].Value = Colabo.IdColaborador;
                DgvListaColaboradores.Rows[nr].Cells[1].Value = Colabo.NombreColaborador;
                DgvListaColaboradores.Rows[nr].Cells[2].Value = Colabo.PrimerApellidoColaborador;
                DgvListaColaboradores.Rows[nr].Cells[3].Value = Colabo.SegundoApellidoColaborador;
                if (Colabo.TipoColaborador== null)
                {
                    DgvListaColaboradores.Rows[nr].Cells[4].Value = Colabo.TipoColaborador;

                }
                else
                {
                    DgvListaColaboradores.Rows[nr].Cells[4].Value =Enum.GetName(typeof(Enums.Tipo_Colaborador), Colabo.TipoColaborador);

                }
            }
        }
    }
}
