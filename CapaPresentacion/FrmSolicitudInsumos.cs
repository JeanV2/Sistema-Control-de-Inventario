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
using System.Web.UI.WebControls;
using System.Windows.Forms;

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
        NegociosInsumosSoli InsumosSoli =new NegociosInsumosSoli();
        private void BtnVerListado_Click(object sender, EventArgs e)
        {
            FrmListaProductos frmListaProductos = new FrmListaProductos();

            frmListaProductos.ShowDialog();

        }


        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            bool validaConfirmacion = true;
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
                    if (InsumosSoli.GuardarInsumos(TbProductoInsumo))
                    {
                        validaConfirmacion =true;
                    }
                    else
                    {
                         validaConfirmacion=false;
                        
                    }


                }

            }
            //-------------------------------------------------------------------------------
    

            if (validaConfirmacion == true)
            {
                MessageBox.Show("Registro exitoso", "Guadar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
