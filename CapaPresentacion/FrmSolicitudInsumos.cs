using CapaEntidades;
using CapaNegocios;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace CapaPresentacion
{
    public partial class FrmSolicitudInsumos : Form
    {
        public FrmSolicitudInsumos()
        {
            InitializeComponent();
        }
        //instacia de datos
        NegocioInsumos insumosIns = new NegocioInsumos();
        NegociosInsumosSoli InsumosSoli = new NegociosInsumosSoli();
        List<TbProducto> productos;
        TbProducto producto = new TbProducto();
        private void BtnVerListado_Click(object sender, EventArgs e)
        {
            FrmListaProductos frmListaProductos = new FrmListaProductos(this);
            frmListaProductos.ShowDialog();

        }


        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            //valida el proceso de guardar
            bool validaConfirmacion = true;
            //valida el proceso de que la cantidad producto no sea mayor que la cantidad producto
            bool ValCantProc = true;
            //obtenemos las filas actuales
            int row = DgvListaProductos.Rows.Count;

            //Creamos la entidad
            TbSolicitudInsumo tbinsumo = new TbSolicitudInsumo();
            //llenamos los datos
            //tbinsumo.IdSolicitudInsumo = ObtenerCodigoSolicitudInsumo().ToString();
            //tbinsumo.FechaInsumo =Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            //tbinsumo.Estado = true;
            //tbinsumo.IdColaborador = FrmLogin.Idetificacion;
            //guardamos la solicitud de insumo
            if (insumosIns.GuardarInsumos(tbinsumo))
            {
                validaConfirmacion = true;
            }
            else
            {
                validaConfirmacion = false;

            }

            //le decimos que recorra los dataview
            TbProductoInsumoS TbProductoInsumo = new TbProductoInsumoS();
            for (int i = 0; i < row; i++)
            {
                if (row != null)
                {
                    //ingresamos los datos
                    //------------------------------------------------------------------------------
                    //tb de producto insumo creamos entidad

                    //lenamos datos

                    TbProductoInsumo.IdSolictudInsumo = tbinsumo.IdSolicitudInsumo;
                    TbProductoInsumo.CantidadP = int.Parse(DgvListaProductos.Rows[i].Cells[2].Value.ToString());
                    TbProductoInsumo.IdProducto = DgvListaProductos.Rows[i].Cells[1].Value.ToString();


                    //-------------------------------------------------------------------------------
                    //vamos guardando cada producto solicitado en la tabla union
                    //validaciones

                    //restamos la cantidad de proc a tbl productos
                    if (RestarantProductos(DgvListaProductos.Rows[i].Cells[1].Value.ToString(), int.Parse(DgvListaProductos.Rows[i].Cells[2].Value.ToString())) == true)
                    {
                        if (InsumosSoli.GuardarInsumos(TbProductoInsumo))
                        {
                            validaConfirmacion = true;
                        }
                        else
                        {
                            validaConfirmacion = false;
                            //hola

                        }
                    }
                    else
                    {
                        validaConfirmacion = false;
                    }


                }

            }
            //-------------------------------------------------------------------------------


            if (validaConfirmacion == true)
            {
                MessageBox.Show("Registro exitoso", "Guadar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvListaProductos.Rows.Clear();
                //Validaciones.LimpiarFormularioSolicitudEntrega(tableLayoutPanel2);
            }
            else
            {
                MessageBox.Show("Error de Registro ", "Guadar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void FrmSolicitudInsumos_Load(object sender, EventArgs e)
        {
            //configuramos el textboxt
            TxtCedula.Text = FrmLogin.NombreCompleto;
            TxtCedula.Enabled = false;


        }

        private string ObtenerCodigoSolicitudInsumo()
        {
            String Codigo = "";
            List<TbSolicitudInsumo> listaproducotoinsumo;
            listaproducotoinsumo = insumosIns.obtenerListaInsumos(0);
            TbSolicitudInsumo tbProductoInsumo = new TbSolicitudInsumo();
            tbProductoInsumo = listaproducotoinsumo.LastOrDefault();

            if (listaproducotoinsumo.Count() > 0)
            {
                if ((int.Parse(tbProductoInsumo.IdSolicitudInsumo) + 1) > 9)
                {
                    if (int.Parse(tbProductoInsumo.IdSolicitudInsumo + 1) > 99)
                    {
                        Codigo = "000" + (int.Parse(tbProductoInsumo.IdSolicitudInsumo) + 1).ToString();
                    }
                    else
                    {
                        Codigo = "0000" + (int.Parse(tbProductoInsumo.IdSolicitudInsumo) + 1).ToString();
                    }
                }
                else
                {
                    Codigo = "00000" + (int.Parse(tbProductoInsumo.IdSolicitudInsumo) + 1).ToString();
                }

            }
            else
            {
                Codigo = "00000";
            }


            return Codigo;
        }
        private bool ValidarProductoGrid()
        {
            bool estado = true;
            int row = DgvListaProductos.Rows.Count;
            for(int i=0; i < row; i++)
            {
                if (DgvListaProductos.Rows[i].Cells[0].Value.ToString().Trim() == TxtCodigoProcd.Text.Trim())
                {
                    estado = false;
                    break;
                }
            }
            return estado;
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if (ValidarProductoGrid() == true)
                {
                    //valido que la cantidad proc se mayor a 0 y menor o = a la cantidad proc disponibles
                    if (ValCantProductos(TxtCodigoProcd.Text, int.Parse(txtCantProducto.Text)) == true)
                    {
                        int row = DgvListaProductos.Rows.Add();
                        DgvListaProductos.Rows[row].Cells[0].Value = TxtCodigoProcd.Text;
                        DgvListaProductos.Rows[row].Cells[1].Value = TxtNombreProduc.Text;
                        DgvListaProductos.Rows[row].Cells[2].Value = txtCantProducto.Text;
                        Limpiarcampos();
                    }
                    else
                    {
                        MessageBox.Show("Verifica que la cantidad de productos sea mayor que 0 menor o igual a la cantidad de productos disponibles", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Este producto ya existe en la solictud", "Solicitud Insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Verifica los campos de texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
        public void Limpiarcampos()
        {
            TxtCodigoProcd.Text = string.Empty;
            TxtNombreProduc.ResetText();
            TxtDisponibles.ResetText();
            txtCantProducto.ResetText();
        }
        private bool RestarantProductos(String Codigo, int cantidad)
        {
            NegociosProductos Insproductos = new NegociosProductos();
            List<TbProducto> listaProductos;
            listaProductos = Insproductos.ListProduct();
            //consultamos si el usuario existe
            bool cod = true;
            foreach (TbProducto pr in listaProductos)
            {

                if (Codigo == pr.CodProducto)
                {
                    int total = (int)pr.CantidadProducto - cantidad;
                    pr.CantidadProducto = total;
                    if (Insproductos.ModificarProduct(pr))
                    {
                        cod = true;
                        break;

                    }
                    else
                    {
                        cod = false;
                    }



                }
                else
                {
                    cod = false;
                }

            }
            return cod;


        }
        private bool ValCantProductos(String Codigo, int cantidad)
        {
            NegociosProductos Insproductos = new NegociosProductos();
            List<TbProducto> listaProductos;
            listaProductos = Insproductos.ListProduct();
            //consultamos si el usuario existe
            bool cod = true;
            foreach (TbProducto pr in listaProductos)
            {

                if (Codigo == pr.CodProducto)
                {
                    if (cantidad > 0)
                    {
                        if (cantidad <= pr.CantidadProducto)
                        {
                            cod = true;
                            break;
                        }
                        else
                        {
                            cod = false;
                        }
                    }
                    else
                    {
                        cod = false;
                    }




                }
                else
                {
                    cod = false;
                }

            }
            return cod;


        }

        private void DgvListaProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                string mensaje = "quitar la fila " + e.RowIndex + " con CodigoProducto " + DgvListaProductos.CurrentRow.Cells[2].Value;
                string caption = "Eliminar Fila";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(mensaje, caption, buttons);


                if (result == DialogResult.Yes)
                {
                    DgvListaProductos.Rows.RemoveAt(e.RowIndex);
                }

            }

        }
        private bool validarCampos()
        {
            if (txtCantProducto.Text == string.Empty)
            {
                txtCantProducto.Focus();
                return false;
            }
            else if (TxtCedula.Text == string.Empty)
            {
                TxtCedula.Focus();
                return false;
            }
            else if (TxtCodigoProcd.Text == string.Empty)
            {
                TxtCodigoProcd.Focus();
                return false;
            }
            else if (TxtNombreProduc.Text == string.Empty)
            {
                TxtNombreProduc.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void DgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en el botón de eliminación
            //if (e.ColumnIndex == DgvListaProductos.Columns["X"].Index && e.RowIndex >= 0)
            //{
            //    // Obtener la fila que se está eliminando
            //    DataGridViewRow fila = DgvListaProductos.Rows[e.RowIndex];

            //    // Eliminar la fila del DataGridView
            //    DgvListaProductos.Rows.Remove(fila);
            //}
        }

        private void TxtCodigoProcd_Leave(object sender, EventArgs e)
        {
            producto.CodProducto = txtCantProducto.Text;

            productos = insumosIns.ObtenerListaProductos(TxtCodigoProcd.Text);

            if (producto.CodProducto == TxtCodigoProcd.Text)
            {

                if (productos != null)
                {
                    foreach (TbProducto pr in productos)
                    {
                        TxtNombreProduc.Text = pr.NombreProducto;
                        int? cantidadProducto = pr.CantidadProducto;
                        TxtDisponibles.Text = cantidadProducto?.ToString();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                DialogResult opc = MessageBox.Show("Codigo digitado no existe", "Error de Codigo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (opc == DialogResult.OK)
                {
                    TxtCodigoProcd.Focus();
                    TxtCodigoProcd.ResetText();
                }
            }
        }

        private void TxtCodigoProcd_Click(object sender, EventArgs e)
        {
            Validaciones.LimpiarFormulario(tableLayoutPanel2);
        }
    }
}
