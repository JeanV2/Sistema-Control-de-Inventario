using CapaEntidades;
using CapaNegocios;
using Guna.UI2.WinForms;
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
    public partial class FrmListaProductos : Form
    {
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Instancia al formulario principal para acceder a los controles que se encuentran en el
        /// </summary>
        FrmAñadirProductos AñadirProductos = (FrmAñadirProductos)Application.OpenForms["FrmAñadirProductos"];
        //------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Instancia al formulario principal para acceder a los controles que se encuentran en el
        /// </summary>
        FrmSolicitudEntrega frmSolicitud = (FrmSolicitudEntrega)Application.OpenForms["FrmSolicitudInsumos"];
        //------------------------------------------------------------------------------------------


        TbProducto producto = new TbProducto();

        private Form FormularioOrigen;
        public FrmListaProductos(Form formularioOrigin)
        {
            InitializeComponent();
            this.FormularioOrigen = formularioOrigin;
        }
        //Lista
        List<TbProducto> lisProductos;
        //Entidad
        TbProducto product = new TbProducto();
        List<TbProducto> productos;
        NegocioInsumos insumosIns = new NegocioInsumos();
        //
        NegociosProductos NegProd = new NegociosProductos();

        public delegate void pasarDatos(TbProducto product);
        public event pasarDatos pasarDatosEvent;
        //-------------------------------------------------------------------------------------------------------------

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

                if (FormularioOrigen is FrmAñadirProductos)
                {
                    //AñadirProductos.TxtCodigoProducto.Text = DgvListaProductos.Rows[fila].Cells[0].Value.ToString();
                    //AñadirProductos.TxtNombreProducto.Text = DgvListaProductos.Rows[fila].Cells[1].Value.ToString();
                    //AñadirProductos.TxtCantidad.Text = DgvListaProductos.Rows[fila].Cells[2].Value.ToString();
                    //AñadirProductos.TxtCosto.Text = DgvListaProductos.Rows[fila].Cells[3].Value.ToString();
                    //AñadirProductos.TxtDescripcion.Text = DgvListaProductos.Rows[fila].Cells[4].Value.ToString();
                    //AñadirProductos.BtnGuardar.Enabled = false;
                    //AñadirProductos.BtnModificar.Visible = true;
                    //AñadirProductos.BtnEliminar.Visible = true;
                    //AñadirProductos.TxtCantidad.Enabled = false;
                    //AñadirProductos.TxtCodigoProducto.ReadOnly = true;
                    //AñadirProductos.TxtNombreProducto.Focus();
                }
                else if (FormularioOrigen is FrmSolicitudEntrega)
                {
                    frmSolicitud.TxtCodigoProcd.Text = DgvListaProductos.Rows[fila].Cells[0].Value.ToString();
                    frmSolicitud.TxtNombreProduc.Text = DgvListaProductos.Rows[fila].Cells[1].Value.ToString();
                    productos = insumosIns.ObtenerListaProductos(DgvListaProductos.Rows[fila].Cells[0].Value.ToString());
                    if (product != null)
                    {
                        foreach (TbProducto pr in productos)
                        {
                            
                            int? cantidadProducto = pr.CantidadProducto;
                            frmSolicitud.TxtDisponibles.Text = cantidadProducto?.ToString();
                        }
                    }
                    else
                    {
                        return;
                    }
                }


                this.Close();
            }
        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {
            lisProductos = NegProd.ListProduct();
            CargarDatos(lisProductos);
        }



        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtCodigo);
        }

        private void FrmListaProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        //busqueda por filtro
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            //buscar
            IEnumerable<TbProducto> listaAux = new List<TbProducto>();

            if (TxtCodigo.Text != string.Empty)
            {

                listaAux = lisProductos.Where(x => x.CodProducto.ToString().Contains(TxtCodigo.Text)).ToList();
                TxtCodigo.ResetText();
            }
            else
            if (TxtNombreProducto.Text != string.Empty)
            {

                listaAux = lisProductos.Where(x => x.NombreProducto.Trim().ToUpper().Contains(TxtNombreProducto.Text.Trim().ToUpper())).ToList();
                TxtNombreProducto.ResetText();
            }
            else
            if (TxtCodigo.Text == string.Empty && TxtNombreProducto.Text == string.Empty)
            {

                listaAux = lisProductos;
            }

            CargarDatos((List<TbProducto>)listaAux);
        }
        //Cargamos datos al data grid
        private void CargarDatos(List<TbProducto> listaProductos)
        {
            DgvListaProductos.Rows.Clear();

            foreach (TbProducto tbProducto in listaProductos)
            {
                int nr = DgvListaProductos.Rows.Add();

                DgvListaProductos.Rows[nr].Cells[0].Value = tbProducto.CodProducto;
                DgvListaProductos.Rows[nr].Cells[1].Value = tbProducto.NombreProducto;
                DgvListaProductos.Rows[nr].Cells[2].Value = tbProducto.CantidadProducto;
                DgvListaProductos.Rows[nr].Cells[3].Value = tbProducto.CostoProducto;
                DgvListaProductos.Rows[nr].Cells[4].Value = tbProducto.Descripcion;
            }
        }
    }
}
