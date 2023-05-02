using CapaEntidades;
using CapaNegocios;
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
        private void BtnVerListado_Click(object sender, EventArgs e)
        {
            FrmListaProductos frmListaProductos = new FrmListaProductos();

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
            tbinsumo.IdSolicitudInsumo = ObtenerCodigoSolicitudInsumo().ToString();
            tbinsumo.FechaInsumo = DateTime.Now;
            tbinsumo.Estado = true;
            tbinsumo.IdColaborador = FrmLogin.Idetificacion;
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
                    TbProductoInsumo.CantidadP = int.Parse(DgvListaProductos.Rows[i].Cells[3].Value.ToString());
                    TbProductoInsumo.IdProducto = DgvListaProductos.Rows[i].Cells[2].Value.ToString();


                    //-------------------------------------------------------------------------------
                    //vamos guardando cada producto solicitado en la tabla union
                    //validaciones
                   
                    //restamos la cantidad de proc a tbl productos
                    if (RestarantProductos(DgvListaProductos.Rows[i].Cells[2].Value.ToString(), int.Parse(DgvListaProductos.Rows[i].Cells[3].Value.ToString()))==true)
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                //valido que la cantidad proc se mayor a 0 y menor o = a la cantidad proc disponibles
                if (ValCantProductos(TxtCodigoProcd.Text, int.Parse(txtCantProducto.Text)) == true)
                {
                    int row = DgvListaProductos.Rows.Add();
                    DgvListaProductos.Rows[row].Cells[0].Value = "x";
                    DgvListaProductos.Rows[row].Cells[1].Value = FrmLogin.Idetificacion;
                    DgvListaProductos.Rows[row].Cells[2].Value = TxtCodigoProcd.Text;
                    DgvListaProductos.Rows[row].Cells[3].Value = txtCantProducto.Text;

                }
                else
                {
                    MessageBox.Show("Verifica que la cantidad de productos sea mayor que 0 menor o igual a la cantidad de productos disponibles", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Verifica los campos de texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

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
                    int total = (int)pr.CantidadProducto-cantidad;
                    pr.CantidadProducto = total;
                    if (Insproductos.ModificarProduct(pr))
                    {
                        cod= true;
                        break;
                      
                    }else
                    {
                        cod= false;
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
            if (e.ColumnIndex == 0)
            {
                string mensaje = "quitar la fila " + e.RowIndex + " con CodigoProducto " + DgvListaProductos.CurrentRow.Cells[2].Value;
                string caption = "Eliminar Fila";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(mensaje, caption, buttons);
        
        
                if (result==DialogResult.Yes)
                {
                    DgvListaProductos.Rows.RemoveAt(e.RowIndex);
                }
               
            }
           
        }
        private bool validarCampos()
        {
            if(txtCantProducto.Text== string.Empty)
            {
                txtCantProducto.Focus();
                return false;
            }else if (TxtCedula.Text == string.Empty)
            {
                TxtCedula.Focus();
                return false;
            }else if (TxtCodigoProcd.Text == string.Empty)
            {
                TxtCodigoProcd.Focus();
                return false;
            }else if (TxtNombreProduc.Text == string.Empty)
            {
                TxtNombreProduc.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
