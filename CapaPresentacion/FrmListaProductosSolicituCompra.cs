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
    public partial class FrmListaProductosSolicituCompra : Form
    {
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Instancia al formulario principal para acceder a los controles que se encuentran en el
        /// </summary>
        FrmSolicitudCompra frmSolicitud = (FrmSolicitudCompra)Application.OpenForms["FrmSolicitudCompra"];
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Istancia de la capa negocios de productos
        /// </summary>
        NegociosProductos Productos= new NegociosProductos();
        public FrmListaProductosSolicituCompra()
        {
            InitializeComponent();
            //Definimos una lista para almacenar los productos
            List<TbProducto> products;
            //rellenamos la lista con los productos
            products = Productos.ListProduct();
            //cargamos el datagridview con los productos
            cargarDt(products);
        }

        /// <summary>
        /// Funcion para cargar un datagridview
        /// </summary>
        public void cargarDt(List<TbProducto> Lista)
        {
            foreach (TbProducto Producto in Lista)
            {
                int row = DgvListaProductos.Rows.Add();
                DgvListaProductos.Rows[row].Cells[0].Value = Producto.CodProducto;
                DgvListaProductos.Rows[row].Cells[1].Value = Producto.NombreProducto;
                DgvListaProductos.Rows[row].Cells[2].Value = Producto.CantidadProducto;
                DgvListaProductos.Rows[row].Cells[3].Value = Producto.CostoProducto;
               
            }
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
                frmSolicitud.TxtPrecioProd.Text = DgvListaProductos.Rows[fila].Cells[3].Value.ToString();
                frmSolicitud.TxtCantidad.Text = DgvListaProductos.Rows[fila].Cells[2].Value.ToString();
                this.Close();
            }
        }

        private void FrmListaProductosSolicituCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void FrmListaProductosSolicituCompra_Load(object sender, EventArgs e)
        {
         
        }

        //filtrar
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            
        }
      
    }
}
