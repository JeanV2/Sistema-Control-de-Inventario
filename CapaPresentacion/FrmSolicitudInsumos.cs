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
                    //que el la cantidad del producto no sea menor que  la cantidad que desea ingresar o que la cantidad que desea ingresa no sea igua a 0  
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

            int row = DgvListaProductos.Rows.Add();
            DgvListaProductos.Rows[row].Cells[0].Value = row;
            DgvListaProductos.Rows[row].Cells[1].Value = FrmLogin.Idetificacion;
            DgvListaProductos.Rows[row].Cells[2].Value = TxtCodigoProcd.Text;
            DgvListaProductos.Rows[row].Cells[3].Value = txtCantProducto.Text;
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
                        if (cantidad < pr.CantidadProducto)
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

    }
}
