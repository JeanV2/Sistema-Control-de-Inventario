﻿using CapaDatos;
using CapaEntidades;
using CapaNegocios;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    //
    public partial class FrmSolicitudCompra : Form
    {


        public FrmSolicitudCompra()
        {
            InitializeComponent();
            //SET DATETIMEPICKER
            DtpFechaSolicitud.MinDate = DateTime.Today;

            TxtSolicitud.Text = ObtenerCodigo_SolicitudCompra();


            //LLenamos el cb de presupuesto con una lista de presupuesto
            PresupuestosList = NPresupuestos.ListaPresupuestos();

        }
        //Instancia a NegocioSolicitudCompra y NegocioProducto
        NegocioSolCompra NegocioSCompra = new NegocioSolCompra();
        NegociosProductos NProducto = new NegociosProductos();
        NegocioPresupuestos NPresupuestos = new NegocioPresupuestos();
        //Lista de presupuesto
        List<TbPresupuesto> PresupuestosList;
        //Para que el listado de productos solo muestre el de diseño presupuesto
        public static string codPrespuesto = "";

        private string ObtenerCodigo_SolicitudCompra()
        {
            String Codigo = "";



            List<TbSolicitudCompra> lista = NegocioSCompra.ListaSolicitudes(); ;
            TbSolicitudCompra Tbultimasolicitud = new TbSolicitudCompra();

            Tbultimasolicitud = lista.LastOrDefault();

            if (lista.Count() > 0)
            {
                if ((int.Parse(Tbultimasolicitud.IdSolicitudCompra) + 1) > 9)
                {
                    Codigo = "0000" + (int.Parse(Tbultimasolicitud.IdSolicitudCompra) + 1).ToString();
                    if ((int.Parse(Tbultimasolicitud.IdSolicitudCompra) + 1) > 99)
                    {
                        Codigo = "0000" + (int.Parse(Tbultimasolicitud.IdSolicitudCompra) + 1).ToString();
                    }
                    else
                    {
                        Codigo = "0000" + (int.Parse(Tbultimasolicitud.IdSolicitudCompra) + 1).ToString();
                    }
                }
                else
                {
                    Codigo = "0000" + (int.Parse(Tbultimasolicitud.IdSolicitudCompra) + 1).ToString();
                }

            }
            else
            {
                Codigo = "00001";
            }




            return Codigo;
        }
        //
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmListaProductosSolicituCompra frmListaProductos = new FrmListaProductosSolicituCompra();
            frmListaProductos.PasarDatosEvent += obtenerCod;
            frmListaProductos.ShowDialog();

        }

        private void obtenerCod(string cod)
        {
            CbCodigoProducto.SelectedValue = cod;

        }



        /// <summary>
        /// valida que no se metan productos repetidos a la lista de compra
        /// </summary>
        /// <returns></returns>
        public bool ValidarRepetido(string codigoProducto)
        {
            bool validar = true;
            for (int i = 0; i < DgvListaCompra.RowCount; i++)
            {

                if (DgvListaCompra.Rows[i].Cells[1].Value.ToString() == codigoProducto)
                {

                    validar = false;
                    break;

                }
                else
                {
                    validar = true;

                }
            }
            return validar;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //VALIDACIONES
            if (TxtNombreProducto.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtNombreProducto);

                //SOLICITUD
                if (TxtSolicitud.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtSolicitud);

                    //CANTIDAD
                    if (TxtCantidad.TextLength > 0)
                    {
                        Validaciones.LimpiarError(TxtCantidad);


                        //COSTO TOTAL
                        if (TxtCostoTotal.TextLength > 0)
                        {
                            Validaciones.LimpiarError(TxtCostoTotal);

                            //PRECIO PRODUCTO
                            if (TxtPrecioProd.TextLength > 0)
                            {
                                Validaciones.LimpiarError(TxtPrecioProd);
                                if (ValidarRepetido(CbCodigoProducto.SelectedValue.ToString()))
                                {
                                    int Row = DgvListaCompra.Rows.Add();

                                    DgvListaCompra.Rows[Row].Cells[0].Value = CbListaPresupuestos.SelectedValue.ToString();
                                    DgvListaCompra.Rows[Row].Cells[1].Value = CbCodigoProducto.SelectedValue.ToString();
                                    DgvListaCompra.Rows[Row].Cells[2].Value = TxtNombreProducto.Text;
                                    DgvListaCompra.Rows[Row].Cells[3].Value = TxtCantidad.Text;
                                    DgvListaCompra.Rows[Row].Cells[4].Value = TxtPrecioProd.Text;
                                    DgvListaCompra.Rows[Row].Cells[5].Value = TxtCostoTotal.Text;

                                    TxtMontuoDisponible.Text = (Convert.ToDouble(TxtMontuoDisponible.Text.Replace("₡", "")) - Convert.ToDouble(TxtCostoTotal.Text.Replace("₡", ""))).ToString();
                                    if (TxtTotalCompra.Text == string.Empty)
                                    {
                                        TxtTotalCompra.Text = "0";
                                    }
                                    TxtTotalCompra.Text = (Convert.ToDouble(TxtTotalCompra.Text.Replace("₡", "")) + Convert.ToDouble(TxtCostoTotal.Text.Replace("₡", ""))).ToString();
                                    //Limpiamos los datos del producto
                                    //Limpiamos el formulario
                                    TxtCantidad.Clear();
                                    TxtPrecioProd.Text = "";
                                    TxtCostoTotal.Clear();
                                    TxtNombreProducto.Text = "";
                                    
                                }
                                else
                                {
                                    MessageBox.Show("El Producto que deseas ingresar ya se encuentra en la lista, si deseas actualizarlo debes quitarlo de la lista y agregarlo nuevamente", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                }



                            }
                            else
                            {
                                Validaciones.MostarError(TxtPrecioProd, "Ingresar precio de producto");
                            }
                        }
                        else
                        {
                            Validaciones.MostarError(TxtCostoTotal, "Ingresar costo total");
                        }

                    }
                    else
                    {
                        Validaciones.MostarError(TxtCantidad, "Ingresar cantidad");
                    }
                }
                else
                {
                    Validaciones.MostarError(TxtSolicitud, "Ingresar número de solicitud");
                }

            }
            else
            {
                Validaciones.MostarError(TxtNombreProducto, "Debes ingresar el monto del presupuesto");
            }
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtCantidad);
        }

        private void TxtPrecioProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtPrecioProd);
        }

        private void TxtCostoTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtCostoTotal);
        }



        private void TxtPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras_y_Numeros(e, TxtNombreProducto);
        }

        private void TxtSolicitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras_y_Numeros(e, TxtSolicitud);
        }

        private void TxtPrecioProd_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioProd.Text != String.Empty)
            {
                TxtCantidad.Enabled = true;
            }
            else
            {
                TxtCantidad.Enabled = false;
            }
            Validaciones.AgregarSimboloColones(TxtPrecioProd);
        }

        private void TxtCostoTotal_TextChanged(object sender, EventArgs e)
        {
            Validaciones.AgregarSimboloColones(TxtCostoTotal);
        }


        private void TxtTotalCompra_TextChanged(object sender, EventArgs e)
        {
            Validaciones.AgregarSimboloColones(TxtTotalCompra);
        }
        public String ObtenerIdColaborador()
        {
            inventarioEntities1 Db = new inventarioEntities1();
            TbColaborador Colab = new TbColaborador();
            Colab = Db.TbColaborador.Where(x => x.NombreColaborador == txtAutoriza.Text).SingleOrDefault();
            return Colab.IdColaborador;
        }
        public void GenerarPDF()
        {

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));
            //*************************
            string PaginaHTML_Texto = Properties.Resources.SolicitudDeCompraPDF.ToString();


            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@fecha", DateTime.Now.ToShortDateString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@solicitante", txtAutoriza.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@N_solicitud",TxtSolicitud.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MontoTotal", TxtTotalCompra.Text);
            //FILES TO INSERT INTO THE PDF FILE
            string filas = string.Empty;
            //COUNTER FOR COUNTING ALL THE APPOINTMENTS IN DB
            int counter = 0;

            //READ THE ELEMENTS INTO THE TABLE 
            foreach (DataGridViewRow row in DgvListaCompra.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells[1].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[2].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[3].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[4].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[5].Value.ToString() + "</td>";
                filas += "</tr>";
                //SET THE COUNTER
                //counter = counter += 1;
            }
            //REPLACE FILES INTO THE HTML DOCUMENT
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            //SET THE APPOINTMENTS TOTAL INTO THE HTML DOCUMENT
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", counter.ToString());

            //************************

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //CREATE A NEW DOCUMENT AS PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //ADD AN IMAGE TO THE DOC WITH STYLES
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.ina, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(120, 120);//SETS IMG SIZE
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;


                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    //IT INSERTS HTML CONTENT TO THE PDF FILE
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();//CLOSES THE PDF DOCUMENT
                    stream.Close();//CLOSES THE FILE IN MEMORY


                    //OPEN THE PDF AFTER BEING SAVED
                    string File_Direcction = savefile.FileName;

                    //OPEN THE FILE
                    string command = File_Direcction;

                    var process = new System.Diagnostics.Process
                    {
                        StartInfo =

                             new System.Diagnostics.ProcessStartInfo(command)
                    };
                    process.Start();
                }

            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            if (DgvListaCompra.RowCount != 0)
            {
                //declaramos todas las entitades a utilizar
                int cont = 0;
                TbSolicitudCompra solicitudCompra = new TbSolicitudCompra();
                TbCompraSolicitudP UnionCompra = new TbCompraSolicitudP();
                NegocioSolCompra NSolicitudC = new NegocioSolCompra();
                NegociosSoliUnionCompra NCompraUnion = new NegociosSoliUnionCompra();
                //completamos todos los datos de la solicitud
                solicitudCompra.IdSolicitudCompra = TxtSolicitud.Text;
                solicitudCompra.IdColaboradorCompra = ObtenerIdColaborador();
                solicitudCompra.FechaSolicitudCompra = Convert.ToDateTime(DtpFechaSolicitud.Value.ToString("yyyy-MM-dd"));
                solicitudCompra.EstadoSolicitud = true;
                solicitudCompra.MontoSolicitudCompra =  Convert.ToDouble(TxtTotalCompra.Text.Replace("₡",""));
                //guardamos la solicitud en el sistema
                NSolicitudC.GuardarSolicitud(solicitudCompra);
                //
                for (int i = 0; i < DgvListaCompra.RowCount; i++)
                {
                    //completamos los datos del producto a guardar
                    UnionCompra.CodProducto = DgvListaCompra.Rows[i].Cells[1].Value.ToString();
                    UnionCompra.Cantidad = int.Parse(DgvListaCompra.Rows[i].Cells[3].Value.ToString());
                    UnionCompra.EstadoSolicitudCompra = true;
                    UnionCompra.IdsolicitudCompra = TxtSolicitud.Text;
                    //guardamos el producto
                    NCompraUnion.GuardarSolicitud(UnionCompra);
                    //Le restamos a inventario requerido y le sumamos a inventario existente
                    //Restamos el total Al presupuesto;
                    RestarPresupuesto(i);
                 
                }
        
        
                if (cont>=DgvListaCompra.Rows.Count)
                {
                    MessageBox.Show("Solicitud creada con exito", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenerarPDF();
                }
                CargarComboPresupuesto();
                DgvListaCompra.Rows.Clear();
                Validaciones.LimpiarFormulario(tableLayoutPanel1);
                TxtTotalCompra.Text = "";
            }
            else
            {
                MessageBox.Show("La solictud de compra no se puede realizar porque no tiene datos que solicitar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void RestarPresupuesto(int i)
        {
            
                inventarioEntities1 Db = new inventarioEntities1();
                TbPresupuesto presupuesto = new TbPresupuesto();
                string presupuestoCod = DgvListaCompra.Rows[i].Cells[0].Value.ToString();
                presupuesto = Db.TbPresupuesto.Where(x => x.numeroCuenta == presupuestoCod).SingleOrDefault();
                double PresupuestoVal = (double)presupuesto.MontoPresupuesto;
                double totalcP =double.Parse( DgvListaCompra.Rows[i].Cells[5].Value.ToString().Replace("₡", ""));
                presupuesto.MontoPresupuesto = PresupuestoVal -totalcP;
                Db.SaveChanges();
            
        }
        public void MasMenosInventario(String CodProducto, int Cantidad)
        {
            //inventarioEntities1 Db = new inventarioEntities1();
            //TbProducto producto = new TbProducto();
            //producto = Db.TbProducto.Where(x => x.CodProducto == CodProducto).SingleOrDefault();
            //if (producto.InventarioRequerido == 0)
            //{
            //    producto.InventarioRequerido = producto.InventarioRequerido;
            //}
            //else
            //{
            //    producto.InventarioRequerido = producto.InventarioRequerido - Cantidad;
            //}
            //producto.InventarioExistente = producto.InventarioExistente + Cantidad;
            //producto.CostoTotal = producto.MUltCosto * producto.InventarioExistente;
            //Db.SaveChanges();

        }
        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            //validamos que el txt no este vacio
            if (TxtCantidad.Text != string.Empty)
            {
                //si txtcantidad es igual a 0 costo total sera igual a 0
                if (TxtCantidad.Text == "0")
                {
                    TxtCostoTotal.Text = "0";
                }
                //caso contrario se multipla el precio del producto por la cantidad
                else
                {
                    //limpiamos el txt de precio producto para que no contenga caracteres invalidos

                    //realizamos la multiplicacion

                    double costo = Convert.ToDouble(TxtCantidad.Text) * Convert.ToDouble(TxtPrecioProd.Text.Replace("₡", ""));
                    try
                    {
                        //mostramos el costo
                        TxtCostoTotal.Text = costo.ToString();
                        string PrespuestoSin = TxtMontuoDisponible.Text;
                        double result = Convert.ToDouble(PrespuestoSin);
                        if (costo > result)
                        {
                            guna2Button1.Enabled = false;
                            MessageBox.Show("Excedió los limites del presepuesto", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            guna2Button1.Enabled = true;

                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No tiene un presupuesto seleccionado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
            else
            {
                TxtCostoTotal.Text = "0";
                guna2Button1.Enabled = false;
            }
        }





        private void TxtMontuoDisponible_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNombreProducto.Text))
            {
                if (!TxtNombreProducto.Text.StartsWith("₡"))
                {
                    TxtNombreProducto.Text = "₡" + TxtNombreProducto.Text;
                    TxtNombreProducto.SelectionStart = TxtNombreProducto.Text.Length;

                }
            }
        }
        /// <summary>
        /// metodo para cargar el Combo de Presupuestos
        /// </summary>
        public void CargarComboPresupuesto()
        {
            NegocioPresupuestos presupuestos = new NegocioPresupuestos();
            List<TbPresupuesto> presupuestosList;
            presupuestosList = presupuestos.ListaPresupuestos();
            CbListaPresupuestos.DataSource = presupuestosList;
            CbListaPresupuestos.DisplayMember = "NombrePresupuesto";
            CbListaPresupuestos.ValueMember = "numeroCuenta";

        }
        /// <summary>
        /// carga el combo de productos segun la seleccion del combo de presupuesto
        /// </summary>
        /// <param name="NumeroCuenta"></param>
        public void CargarComboProductos(string NumeroCuenta)
        {
            try
            {
                inventarioEntities1 db = new inventarioEntities1();
                CbCodigoProducto.DataSource = db.TbProducto.Where(x => x.CFamilia == NumeroCuenta).ToList();
                CbCodigoProducto.DisplayMember = "CodProducto";
                CbCodigoProducto.ValueMember = "CodProducto";
            }
            catch (Exception)
            {
                MessageBox.Show("Tenemos problema con el servidor, por favor reinicie el programa", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
           
        }
        /// <summary>
        /// carga los campos segun la seleeccion del combo de codigo de producto
        /// </summary>
        /// <param name="CodigoProducto"></param>
        public void CargarCamposProducto(String CodigoProducto)
        {
            inventarioEntities1 db = new inventarioEntities1();
            List<TbProducto> ListProd = db.TbProducto.Where(x => x.CodProducto == CodigoProducto).ToList();
            foreach (TbProducto Prod in ListProd)
            {
                TxtNombreProducto.Text = Prod.DesResumida;
                TxtPrecioProd.Text = Prod.MUltCosto.ToString();
                TxtInvenRequerido.Text=Prod.InventarioRequerido.ToString();
                TxtInvExistente.Text=Prod.InventarioExistente.ToString();
            }
            ListProd.Clear();
        }
        /// <summary>
        /// carga el monto del presupuesto segun la seleccion del combo de presupuesto
        /// </summary>
        /// <param name="NumeroCuenta"></param>
        public void CargarCampoPresupuesto(String NumeroCuenta)
        {
            inventarioEntities1 db = new inventarioEntities1();
            List<TbPresupuesto> listPre = db.TbPresupuesto.Where(x => x.numeroCuenta == NumeroCuenta).ToList();
            //Variable para alamcenar el total de costo que hay que bajarle al presupuesto esto si ya el producto se encuentra en el datagrid
            double TotalBajarPresupuesto=0;
            for (int i = 0; i < DgvListaCompra.RowCount; i++)
            {
                if (DgvListaCompra.Rows[i].Cells[0].Value.ToString()==CbListaPresupuestos.SelectedValue)
                {
                    TotalBajarPresupuesto = TotalBajarPresupuesto + Convert.ToDouble(DgvListaCompra.Rows[i].Cells[5].Value.ToString().Replace("₡", ""));
                }
             }
            foreach (TbPresupuesto Pre in listPre)
            {
               
                    TxtMontuoDisponible.Text =((double) Pre.MontoPresupuesto-TotalBajarPresupuesto).ToString();
            }
        }

        private void FrmSolicitudCompra_Load_1(object sender, EventArgs e)
        {
            txtAutoriza.Text = FrmLogin.NombreCompleto;
            CargarComboPresupuesto();
        }

        private void CbListaPresupuestos_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void CbListaPresupuestos_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CbCodigoFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbCodigoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbCodigoProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void DgvListaCompra_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == DgvListaCompra.Columns["x"].Index && e.RowIndex >= 0)
            {
                int Row = e.RowIndex;
                double Presupuesto = Convert.ToDouble(TxtMontuoDisponible.Text.Replace("₡", ""));
                double CostoTotal = Convert.ToDouble(DgvListaCompra.Rows[Row].Cells[5].Value.ToString().Replace("₡", ""));
                TxtMontuoDisponible.Text = (Presupuesto + CostoTotal).ToString();
                TxtTotalCompra.Text = (Convert.ToDouble(TxtTotalCompra.Text.Replace("₡", "")) - CostoTotal).ToString();

                // Obtener la fila que se está eliminando
                DataGridViewRow fila = DgvListaCompra.Rows[e.RowIndex];

                // Eliminar la fila del DataGridView

                DgvListaCompra.Rows.Remove(fila);

            }
        }

        private void CbListaPresupuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpiamos el formulario
            TxtCantidad.Clear();
            TxtPrecioProd.Text="";
            TxtCostoTotal.Clear();
            TxtNombreProducto.Text="";
            TxtMontuoDisponible.Text = "" ;
            CargarCampoPresupuesto(CbListaPresupuestos.SelectedValue.ToString());
            codPrespuesto = CbListaPresupuestos.SelectedValue.ToString();
            CargarComboProductos(CbListaPresupuestos.SelectedValue.ToString());
        }

        private void FrmSolicitudCompra_Load(object sender, EventArgs e)
        {
            CargarComboPresupuesto();
            txtAutoriza.Text = FrmLogin.NombreCompleto;
        }

        private void CbCodigoProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CargarCamposProducto(CbCodigoProducto.SelectedValue.ToString());

        }
    }

}
