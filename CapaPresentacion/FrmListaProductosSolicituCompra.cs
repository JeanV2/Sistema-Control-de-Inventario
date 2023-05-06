using CapaDatos;
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
        List<TbProducto> products;
       
        FrmSolicitudCompra FrmSolicitud = (FrmSolicitudCompra)Application.OpenForms["FrmListaProductosSolicituCompra"];
        
        public FrmListaProductosSolicituCompra()
        {
            InitializeComponent();
            //Definimos una lista para almacenar los productos
         
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
            inventarioEntities1 Db = new inventarioEntities1();
            List<TbProducto> ListaProductos;

           
            if (TxtCodigoPresupuesto.Text!=string.Empty && TxtProducto.Text!=string.Empty)
            {
                //busqueda por los dos
                DgvListaProductos.Rows.Clear();
                ListaProductos = Db.TbProducto.Where(x => x.CFamilia == TxtCodigoPresupuesto.Text && x.CodProducto == TxtProducto.Text).ToList();
                cargarDt(ListaProductos);
            }else if (TxtCodigoPresupuesto.Text!=string.Empty)
            {
                //solo por presupuesto
                DgvListaProductos.Rows.Clear();
                ListaProductos = Db.TbProducto.Where(x => x.CFamilia == TxtCodigoPresupuesto.Text).ToList();
                cargarDt(ListaProductos);
            }
            else if (TxtProducto.Text!=string.Empty)
            {
                //solo por cod Producto
                DgvListaProductos.Rows.Clear();
                ListaProductos = Db.TbProducto.Where(x => x.CodProducto == TxtProducto.Text).ToList();
                cargarDt(ListaProductos);
            }
            else
            {
                cargarDt(products);
            }
        }

        private void DgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                FrmSolicitud.TxtCantidad.Text = DgvListaProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.Close();

            }
        }
    }
}
