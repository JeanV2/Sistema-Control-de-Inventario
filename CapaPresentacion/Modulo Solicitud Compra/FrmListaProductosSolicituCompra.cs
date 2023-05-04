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

        /// <summary>
        /// Istancia de la capa negocios de productos
        /// </summary>
        NegociosProductos Productos = new NegociosProductos();
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
                DgvListaProductos.Rows[row].Cells[0].Value = Producto.CFamilia;
                DgvListaProductos.Rows[row].Cells[1].Value = Producto.CSubFamilia;
                DgvListaProductos.Rows[row].Cells[2].Value = Producto.NumProducto;
                DgvListaProductos.Rows[row].Cells[3].Value = Producto.CodProducto;
                DgvListaProductos.Rows[row].Cells[4].Value = Producto.DesResumida;
                DgvListaProductos.Rows[row].Cells[5].Value = Producto.CFUnidadMedida;
                DgvListaProductos.Rows[row].Cells[6].Value = Producto.InventarioRequerido;
                DgvListaProductos.Rows[row].Cells[7].Value = Producto.MUltCosto;
                DgvListaProductos.Rows[row].Cells[8].Value = Producto.CostoTotal;
                DgvListaProductos.Rows[row].Cells[9].Value = Producto.InventarioExistente;

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
