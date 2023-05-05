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
            listapresupuestos = inspresupuestos.ListaPresupuestos();

            CargarComboPresupuestos(listapresupuestos);
            RefrescarComboProductos();
        }
        public void RefrescarComboProductos()
        {
   
            listaProductos = Insproductos.ListProduct();
            int valorCombo =( CbNombrePresupuesto.SelectedItem as OpcionCombo).valor;
            IEnumerable<TbProducto> listaaux = new List<TbProducto>();
            if (valorCombo>0)
            {
                listaaux = listaProductos.Where(x => x.CFamilia.Trim().ToUpper().Contains(valorCombo.ToString().Trim().ToUpper())).ToList();
            }

            if (listaaux.Count() ==0)
            {
                MessageBox.Show("Actualmente no tiene productos relacionados a este presupuesto","advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                CbCodigoProducto.Items.Clear();
                CbCodigoProducto.Enabled = false;

            }
            else
            {
                
                CargarComboProductos((List<TbProducto>)listaaux);
            }
           

        }

        private void CargarComboPresupuestos(List<TbPresupuesto> ListPre)
        {
            int valor = 0;
            string texto ="";
            foreach (TbPresupuesto presupuestos in ListPre)
            {

                valor = int.Parse(presupuestos.numeroCuenta);
                texto = presupuestos.nombrePresupuesto.ToString();
                CbNombrePresupuesto.Items.Add(new OpcionCombo() { valor = valor, texto = texto });

            }
          
            CbNombrePresupuesto.DisplayMember = "texto";
            CbNombrePresupuesto.ValueMember = "valor";
          
            CbNombrePresupuesto.SelectedIndex = 0;

        }






        private void CargarComboProductos(List<TbProducto> ListPro)
        {
            CbCodigoProducto.Items.Clear();
            CbCodigoProducto.Enabled = true;
            string valor = "";
            string texto = "";
            foreach (TbProducto producto in ListPro)
            {

                valor =producto.CodProducto;
                texto = producto.DesResumida.ToString();
                CbCodigoProducto.Items.Add(new OpcionCombo2() { valor = valor, texto = texto });

            }

            CbCodigoProducto.DisplayMember = "texto";
            CbCodigoProducto.ValueMember = "valor";

            CbCodigoProducto.SelectedIndex = 0;

        }

        public void Limpiarcampos()
        {

          
            txtCantProducto.ResetText();
        }

        private bool ValidarProductoGrid()
        {
            bool estado = true;
            int row = DgvListaProductos.Rows.Count;
            for (int i = 0; i < row; i++)
            {
                if (DgvListaProductos.Rows[i].Cells[0].Value.ToString().Trim() == (CbCodigoProducto.SelectedItem as OpcionCombo2).valor)
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
        private bool ValCantProductos()
        {

           
            bool cod = true;


            if (TxtDisponibles.Text == string.Empty)
            {
                cod = false;
            }else
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
            tbinsumo.IdSolicitudInsumo = ObtenerCodigoSolicitudInsumo().ToString();
            tbinsumo.IdColaboradorRecibe=TxtSolicitadoPor.ToString();
            //tbinsumo.tipoSolicitud = CbTipoSilicitud.SelectedItem.ToString();
            tbinsumo.ReferenciaCurso = TxtReferencia.Text;
                    
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
            TxtDisponibles.Enabled = false;
            TxtCedula.ReadOnly = true;
            RefrescarComboPresupuestos();

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
                if (ValCantProductos() == true)
                {
                    if (ValidarProductoGrid() == true)
                    {
                        int row = DgvListaProductos.Rows.Add();
                        DgvListaProductos.Rows[row].Cells[0].Value = (CbCodigoProducto.SelectedItem as OpcionCombo2).valor;
                        DgvListaProductos.Rows[row].Cells[1].Value = (CbCodigoProducto.SelectedItem as OpcionCombo2).texto;
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

        private void CbNombrePresupuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarComboProductos();
        }

        private void CbCodigoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //consultamos id del producto y mostramos la cantidad disponibles
            listaProductos = Insproductos.ListProduct();
            string valorCombo = (CbCodigoProducto.SelectedItem as OpcionCombo2).valor;
            IEnumerable<TbProducto> listaaux = new List<TbProducto>();
            if (valorCombo != string.Empty)
            {
                listaaux = listaProductos.Where(x => x.CodProducto.Trim().ToUpper().Contains(valorCombo.ToString().Trim().ToUpper())).ToList();
            }

            if (listaaux.Count() == 0)
            {
                TxtDisponibles.Text = "0";
            }
            else
            {
                string canPro = "0";

                foreach (TbProducto producto in (List<TbProducto>)listaaux)
                {

                    canPro = producto.NumProducto;

                }
                TxtDisponibles.Text = canPro;
            }
        }
    }
}
