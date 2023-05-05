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
using Utilidades;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace CapaPresentacion
{
    public partial class FrmSolicitudEntrega : Form
    {
        
        //instacia de datos
        NegocioInsumos insumosIns = new NegocioInsumos();
        NegociosInsumosSoli InsumosSoli = new NegociosInsumosSoli();
        List<TbProducto> productos;
        TbProducto producto = new TbProducto();
        NegociosProductos Insproductos = new NegociosProductos();
        List<TbProducto> listaProductos;

        public void Limpiarcampos()
        {

            TxtDisponibles.ResetText();
            txtCantProducto.ResetText();
        }

        private bool ValidarProductoGrid()
        {
            bool estado = true;
            int row = DgvListaProductos.Rows.Count;
            for (int i = 0; i < row; i++)
            {
                if (DgvListaProductos.Rows[i].Cells[0].Value.ToString().Trim() == CbCodigoProducto.SelectedValue.ToString())
                {
                    estado = false;
                    break;
                }
            }
            return estado;
        }

        private bool RestarantProductos(String Codigo, int cantidad)
        {
            
            listaProductos = Insproductos.ListProduct();
            //consultamos si el usuario existe
            bool cod = true;
            foreach (TbProducto pr in listaProductos)
            {

                if (Codigo == pr.CodProducto)
                {
                    int total = (int)pr.InventarioExistente - cantidad;
                    pr.InventarioExistente = total;
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
            
            listaProductos = Insproductos.ListProduct();
            //consultamos si el usuario existe
            bool cod = true;
            foreach (TbProducto pr in listaProductos)
            {

                if (Codigo == pr.CodProducto)
                {
                    if (cantidad > 0)
                    {
                        if (cantidad <= pr.InventarioExistente)
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

        /// <summary>
        /// Metodo para validar campos vacios
        /// </summary>
        /// <returns>Retorna true si todos los campos tienen datos correctos</returns>
        private bool validarCampos()
        {
            if (TxtSolicitadoPor.Text != string.Empty)
            {
                Validaciones.LimpiarError(TxtSolicitadoPor);

                if (CbTipoSilicitud.SelectedIndex > -1)
                {
                    Validaciones.LimpiarErrorCombo(CbTipoSilicitud);

                    if (TxtReferencia.Text != string.Empty)
                    {
                        Validaciones.LimpiarError(TxtReferencia);

                        if (CbNombrePresupuesto.SelectedIndex > -1)
                        {
                            Validaciones.LimpiarErrorCombo(CbNombrePresupuesto);

                            if (CbCodigoProducto.SelectedIndex > -1)
                            {
                                Validaciones.LimpiarErrorCombo(CbCodigoProducto);

                                if (TxtDisponibles.Text != "0")
                                {
                                    Validaciones.LimpiarError(TxtDisponibles);

                                    if (txtCantProducto.Text != string.Empty)
                                    {
                                        Validaciones.LimpiarError(txtCantProducto);
                                        return true;
                                    }
                                    else
                                    {
                                        Validaciones.MostarError(txtCantProducto, "Debes ingresar la cantidad a retirar");
                                        return false;
                                    }
                                }
                                else
                                {
                                    Validaciones.MostarError(TxtDisponibles, "La cantidad de productos existentes es 0 no puedes retirar este articulo ya que no hay en bodega");
                                    return false;
                                }
                            }
                            else
                            {
                                Validaciones.MostarErrorCombo(CbCodigoProducto, "Debes seleccionar un producto");
                                return false;
                            }
                        }
                        else
                        {
                            Validaciones.MostarErrorCombo(CbNombrePresupuesto, "Debes seleccionar un presupuesto");
                            return false;
                        }
                    }
                    else
                    {
                        Validaciones.MostarError(TxtReferencia, "Debes ingresar los datos de la referencia del retiro");
                        return false;
                    }
                }
                else
                {
                    Validaciones.MostarErrorCombo(CbTipoSilicitud, "Debes seleccionar el tipo de solitud");
                    return false;
                }
            }
            else
            {
                Validaciones.MostarError(TxtSolicitadoPor, "Debes ingresar el nombre de quien realiza la solicitud de retiro");
                return false;
            }
        }







        public FrmSolicitudEntrega()
        {
            InitializeComponent();
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
            TxtCedula.ReadOnly = true;

            CbTipoSilicitud.DataSource = Enum.GetValues(typeof(Enums.Tipo_retiro));
            
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
                if (ValidarProductoGrid() == true)
                {
                    int row = DgvListaProductos.Rows.Add();
                    DgvListaProductos.Rows[row].Cells[0].Value = CbCodigoProducto.ValueMember.ToString();
                    DgvListaProductos.Rows[row].Cells[1].Value = CbCodigoProducto.DisplayMember;
                    DgvListaProductos.Rows[row].Cells[2].Value = txtCantProducto.Text;
                    Limpiarcampos();

                }
                else
                {
                    MessageBox.Show("Este producto ya existe en la solictud", "Solicitud Insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                return;

            }

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


        private void DgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verificar si se hizo clic en el botón de eliminación
            if (e.ColumnIndex == DgvListaProductos.Columns["X"].Index && e.RowIndex >= 0)
            {
                // Obtener la fila que se está eliminando
                DataGridViewRow fila = DgvListaProductos.Rows[e.RowIndex];

                // Eliminar la fila del DataGridView
                DgvListaProductos.Rows.Remove(fila);
            }
        }




        private void TxtSolicitadoPor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.LetrasEspacio_y_Borrar(e, TxtSolicitadoPor);
        }

        private void txtCantProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, txtCantProducto);
        }

        private void CbTipoSilicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbTipoSilicitud.SelectedIndex == 0)
            {
                TxtReferencia.Enabled = true;
            }
            if (CbTipoSilicitud.SelectedIndex == 1)
            {
                TxtReferencia.Enabled = false;
            }
        }
    }
}
