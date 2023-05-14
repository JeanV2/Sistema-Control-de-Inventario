using CapaDatos;
using CapaEntidades;
using CapaNegocios;
using Microsoft.Office.Interop.Excel;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Utilidades;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using static Utilidades.Enums;

namespace CapaPresentacion
{
    public partial class FrmSolicitudEntrega : Form
    {
        public class OpcionCombo
        {
            public int valor { get; set; }
            public string texto { get; set; }
        }
        public class OpcionCombo2
        {
            public string valor { get; set; }
            public string texto { get; set; }
        }
        //instacia de datos
        NegocioInsumos insumosIns = new NegocioInsumos();
        NegociosInsumosSoli InsumosSoli = new NegociosInsumosSoli();

        //---------------------
        NegociosProductos Insproductos = new NegociosProductos();
        List<TbProducto> listaProductos;

        //lista presupuestos

        NegocioPresupuestos inspresupuestos = new NegocioPresupuestos();
        List<TbPresupuesto> listapresupuestos;
        public void RefrescarComboPresupuestos()
        {


            CargarComboPresupuestos();

        }


        private void CargarComboPresupuestos()
        {
            listapresupuestos = inspresupuestos.ListaPresupuestos();
            CbNombrePresupuesto.DataSource = listapresupuestos;
            CbNombrePresupuesto.DisplayMember = "NombrePresupuesto";
            CbNombrePresupuesto.ValueMember = "numerocuenta";
        }






        private void CargarComboProductos(string NumeroCuenta)
        {
            try
            {

                inventarioEntities1 db = new inventarioEntities1();
                CbCodigoProducto.DataSource = db.TbProducto.Where(x => x.CFamilia == NumeroCuenta).ToList();
                CbCodigoProducto.DisplayMember = "DesResumida";
                CbCodigoProducto.ValueMember = "CodProducto";

            }
            catch (Exception)
            {
                MessageBox.Show("Tenemos problema con el servidor, por favor reinicie el programa", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        public void Limpiarcampos()
        {
            txtCantProducto.Clear();
            TxtDisponibles.Clear();
            CbCodigoProducto.SelectedIndex = -1;
        }

        private bool ValidarProductoGrid()
        {
            bool estado = true;
            int row = DgvListaProductos.Rows.Count;
            for (int i = 0; i < row; i++)
            {
                if (DgvListaProductos.Rows[i].Cells[0].Value.ToString().Trim() == CbCodigoProducto.SelectedValue)
                {
                    estado = false;
                    break;
                }
            }
            return estado;
        }


        private bool ValCantProductos()
        {


            bool cod = true;


            if (TxtDisponibles.Text == string.Empty)
            {
                cod = false;
            }
            else
            {
                if (int.Parse(txtCantProducto.Text) <= 0)
                {
                    MessageBox.Show("La cantidad de Productos solicitados no puede ser = a 0 ", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cod = false;
                }
                if (int.Parse(txtCantProducto.Text) > int.Parse(TxtDisponibles.Text))
                {
                    MessageBox.Show("La cantidad de Productos solicitados no puede ser mayor a los disponibles ", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    cod = false;
                }
            }
            return cod;




        }
        private bool validarRef()
        {
            bool validar = false;
            if ((int)CbTipoSilicitud.SelectedValue==0)
            {

                validar = true;
            
            }
            else
            {
                if (TxtReferencia.Text==string.Empty)
                {
                    Validaciones.MostarError(TxtReferencia, "Debes ingresar los datos de la referencia del retiro");

                    validar = false;
                }
                else
                {
                    validar = true;
                }
              
            }
           return validar;
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
                        //Validaciones.MostarError(TxtReferencia, "Debes ingresar los datos de la referencia del retiro");
                        return validarRef();
                    }
                }
                else
                {
                    Validaciones.MostarErrorCombo(CbTipoSilicitud, "Debes seleccionar el tipo de solitud");
                    return false;
                    //soy kelvin y no se usar git
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
            MessageBox.Show(row.ToString());
            //Creamos la entidad
            TbSolicitudInsumo tbinsumo = new TbSolicitudInsumo();
            string consecutivo = ObtenerCodigoSolicitudInsumo().ToString();
            //llenamos los datos
            tbinsumo.IdSolicitudInsumo = consecutivo;
            tbinsumo.IdColaboradorEntrega = FrmLogin.Idetificacion;
            tbinsumo.IdColaboradorRecibe = TxtSolicitadoPor.Text.ToString();
            tbinsumo.tipoSolicitud = (int)CbTipoSilicitud.SelectedValue;
            if (CbTipoSilicitud.SelectedIndex == 1)
            {
                tbinsumo.ReferenciaCurso = "No Aplica";
            }
            else
            {
                tbinsumo.ReferenciaCurso = TxtReferencia.Text;
            }

            tbinsumo.EstadoSolicitud = true;
            tbinsumo.fechaSolicitud = DateTime.Now;
            //guardamos la solicitud de insumo
            insumosIns.GuardarInsumos(tbinsumo);



            inventarioEntities1 db = new inventarioEntities1();
            //le decimos que recorra los dataview
            TbProductoInsumoS TbProductoInsumo = new TbProductoInsumoS();
            TbProducto producto = new TbProducto();
            for (int i = 0; i < row; i++)
            {
                if (row != null)
                {
                    //ingresamos los datos
                    //------------------------------------------------------------------------------
                    //tb de producto insumo creamos entidad

                    //lenamos datos

                    TbProductoInsumo.IdSolictudInsumo = consecutivo;
                    TbProductoInsumo.CantidadP = int.Parse(DgvListaProductos.Rows[i].Cells[2].Value.ToString());
                    TbProductoInsumo.IdProducto = DgvListaProductos.Rows[i].Cells[0].Value.ToString();
                    InsumosSoli.GuardarInsumos(TbProductoInsumo);

                    //-------------------------------------------------------------------------------
                    //vamos guardando cada producto solicitado en la tabla union
                    //validaciones
                    string cod = DgvListaProductos.Rows[i].Cells[0].Value.ToString();
                    producto = db.TbProducto.Where(x => x.CodProducto == cod).SingleOrDefault();
                    producto.InventarioExistente = producto.InventarioExistente - int.Parse(DgvListaProductos.Rows[i].Cells[2].Value.ToString());
                    //restamos la cantidad de proc a tbl productos

                    db.SaveChanges();
                
                  

                }
         
            }
            //-------------------------------------------------------------------------------
            MessageBox.Show("Registro exitoso", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiarcampos();
            CargarComboPresupuestos();
            DgvListaProductos.Rows.Clear();

        }


        private void FrmSolicitudInsumos_Load(object sender, EventArgs e)
        {
            //configuramos el textboxt
            TxtCedula.Text = FrmLogin.NombreCompleto;
            TxtCedula.Enabled = false;
            TxtDisponibles.Enabled = false;
            TxtCedula.ReadOnly = true;
            listapresupuestos = inspresupuestos.ListaPresupuestos();
            CargarComboPresupuestos();

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
            inventarioEntities1 db = new inventarioEntities1();

            if (validarCampos())
            {
                if (ValCantProductos() == true)
                {
                    if (ValidarProductoGrid() == true)
                    {
                        int row = DgvListaProductos.Rows.Add();
                        DgvListaProductos.Rows[row].Cells[0].Value = CbCodigoProducto.SelectedValue;
                        DgvListaProductos.Rows[row].Cells[1].Value = db.TbProducto.Where(x => x.CodProducto == CbCodigoProducto.SelectedValue).FirstOrDefault().DesResumida;
                        DgvListaProductos.Rows[row].Cells[2].Value = txtCantProducto.Text;

                        Limpiarcampos();

                    }
                    else
                    {
                        MessageBox.Show("Este producto ya existe en la solictud", "Solicitud Insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                string mensaje = "quitar la fila " + e.RowIndex + " con CodigoProducto " + DgvListaProductos.CurrentRow.Cells[0].Value;
                string caption = "Eliminar Fila";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(mensaje, caption, buttons);


                if (result == DialogResult.Yes)
                {

                    if (DgvListaProductos.Rows[e.RowIndex].Cells[0].Value == CbCodigoProducto.SelectedValue)
                    {
                        TxtDisponibles.Text = (int.Parse(TxtDisponibles.Text) + int.Parse(DgvListaProductos.Rows[e.RowIndex].Cells[2].Value.ToString())).ToString();
                    }
                    DgvListaProductos.Rows.RemoveAt(e.RowIndex);
                }


            }

        }


        private void DgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ////Verificar si se hizo clic en el botón de eliminación
            //if (e.ColumnIndex == DgvListaProductos.Columns["X"].Index && e.RowIndex >= 0)
            //{
            //    // Obtener la fila que se está eliminando
            //    DataGridViewRow fila = DgvListaProductos.Rows[e.RowIndex];

            //    // Eliminar la fila del DataGridView
            //    MessageBox.Show(DgvListaProductos.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + CbCodigoProducto.SelectedValue);

            //    DgvListaProductos.Rows.Remove(fila);
            //}

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
                TxtReferencia.Enabled = false;
                TxtReferencia.Text = "No Aplica";

            }
            if (CbTipoSilicitud.SelectedIndex == 1)
            {
                TxtReferencia.Enabled = true;
                TxtReferencia.Text = string.Empty;
            }
        }
        private void CbNombrePresupuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboProductos(CbNombrePresupuesto.SelectedValue.ToString());
        }

        private void CbCodigoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            inventarioEntities1 db = new inventarioEntities1();
            //Validamos que el index de cb no sea -1 para evitar que se caiga al limpiar el formulario
            if (CbCodigoProducto.SelectedIndex != -1)
            {
                //Obtenemos la cantidad del producto seleccionado el cb y lo mostramos el txt pero antes de eso hay que verificar que no este ya en el datagrid
                int CantidadProducto = (int)db.TbProducto.Where(x => x.CodProducto == CbCodigoProducto.SelectedValue).FirstOrDefault().InventarioExistente;
                //Recorremos el datagrid y si encontramos el producto restarle a la cantidad disponible antes de mostrarla
                for (int i = 0; i < DgvListaProductos.Rows.Count; i++)
                {

                    if (CbCodigoProducto.SelectedValue == DgvListaProductos.Rows[i].Cells[0].Value)
                    {
                        int dtCantidad = int.Parse(DgvListaProductos.Rows[i].Cells[2].Value.ToString()
                            );
                        CantidadProducto = CantidadProducto - dtCantidad;

                    }
                }

                TxtDisponibles.Text = CantidadProducto.ToString();

            }
        }

        private void TxtReferencia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
