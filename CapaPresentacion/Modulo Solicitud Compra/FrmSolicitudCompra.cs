﻿using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
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
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmListaProductosSolicituCompra frmListaProductos = new FrmListaProductosSolicituCompra();
            frmListaProductos.ShowDialog();
            TxtCantidad.Text = "";
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

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            if (DgvListaCompra.RowCount != 0)
            {
                // CODIGO PARA GUARDAR

                //Entidad de la solicitud de compra
                TbSolicitudCompra Scompra = new TbSolicitudCompra();
                Scompra.IdSolicitudCompra = TxtSolicitud.Text;
                Scompra.FechaSolicitudCompra = DtpFechaSolicitud.Value;
                Scompra.IdColaboradorCompra = FrmLogin.Idetificacion.ToString();
                //Scompra.EstadoSolicitudCompra = true;

                NegocioSCompra.GuardarSolicitud(Scompra);
                //Entidad de los productos para guardarlos relacionandolo con la id de la solicitud
                TbCompraSolicitudP compraP = new TbCompraSolicitudP();
                TbProducto Producto = new TbProducto();
                for (int r = 0; r < DgvListaCompra.RowCount; r++)
                {
                    //Actualizamos la cantidad en stock del producto primero que todo
                    List<TbProducto> ListaProducto = new List<TbProducto>();
                    ListaProducto = NProducto.ListProduct();
                    foreach (var item in ListaProducto)
                    {
                        if (item.CodProducto == DgvListaCompra.Rows[r].Cells[1].Value.ToString())
                        {
                            //Producto.CodProducto = item.CodProducto;
                            //Producto.NombreProducto = item.NombreProducto;
                            //Producto.CostoProducto = item.CostoProducto;
                            //Producto.Descripcion = item.Descripcion;
                            //Producto.CantidadProducto = item.CantidadProducto + int.Parse(DgvListaCompra.Rows[r].Cells[2].Value.ToString());
                            //NProducto.ModificarProduct(Producto);
                        }

                    }
                    //Agregamos el producto a la solitud de compra
                    compraP.CodProducto = DgvListaCompra.Rows[r].Cells[1].Value.ToString();
                    compraP.Cantidad = int.Parse(DgvListaCompra.Rows[r].Cells[2].Value.ToString());
                    compraP.EstadoSolicitudCompra = true;
                    compraP.IdsolicitudCompra = TxtSolicitud.Text;

                    NegocioSCompra.GuardarbCompraSolicitudProductos(compraP);

                }
                //actualizamos el presupuesto
                TbPresupuesto PresupuestoTb = new TbPresupuesto();
                foreach (var item in PresupuestosList)
                {


                    //if (item.IdPresupuesto == CbListaPresupuestos.SelectedItem)
                    //{
                    //    //realizamos el rebajo al presupuesto
                    //    double Presupuesto;
                    //    Presupuesto = (double)item.MontoPresupuesto;
                    //    Presupuesto = Presupuesto - double.Parse(TxtCostoTotal.Text);
                    //    //y actualizamos el presupuesto
                    //    PresupuestoTb.IdPresupuesto = item.IdPresupuesto;
                    //    PresupuestoTb.MontoPresupuesto = Presupuesto;
                    //    PresupuestoTb.MesPresupuesto = item.MesPresupuesto;
                    //    PresupuestoTb.EstadoPresupuesto = false;
                    //    NPresupuestos.EditarPresupuesto(PresupuestoTb);


                    //    //if (item.IdPresupuesto == CbListaPresupuestos.SelectedItem)
                    //    //{
                    //    //    //realizamos el rebajo al presupuesto
                    //    //    double Presupuesto;
                    //    //    Presupuesto = (double)item.MontoPresupuesto;
                    //    //    Presupuesto = Presupuesto - int.Parse(TxtTotalCompra.Text);
                    //    //    //y actualizamos el presupuesto
                    //    //    PresupuestoTb.IdPresupuesto = item.IdPresupuesto;
                    //    //    PresupuestoTb.MontoPresupuesto = Presupuesto;
                    //    //    PresupuestoTb.MesPresupuesto = item.MesPresupuesto;
                    //    //    PresupuestoTb.EstadoPresupuesto = false;
                    //    //    NPresupuestos.EditarPresupuesto(PresupuestoTb);



                    //    //}
                    //}

                    //LIMPIAR FORM
                    Validaciones.LimpiarFormulario(tableLayoutPanel1);

                    DgvListaCompra.Rows.Clear();
                    DgvListaCompra.Columns.Clear();


                    DgvListaCompra.Rows.Clear();

                    //CLEAR DATE TIME PICKER
                    DtpFechaSolicitud.Value = DateTime.Today;
                    //CLEAR DATA GRID VIEW
                    // -- ACA VA EL CODIGO PARA LIMPIAR EL DATA GRIG VIEW

                    MessageBox.Show("La solictud de compra se a realizado con exitó", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //LIMPIAR FORM

                    Validaciones.LimpiarFormulario(tableLayoutPanel1);
                    TxtNombreProducto.Clear();

                    Validaciones.LimpiarFormulario(tableLayoutPanel1);
                    CbListaPresupuestos.SelectedIndex = -1;



                    //CLEAR DATE TIME PICKER
                    DtpFechaSolicitud.Value = DateTime.Today;
                    TxtTotalCompra.Clear();
                    //CLEAR DATA GRID VIEW and generate code
                    DgvListaCompra.Rows.Clear();
                    TxtSolicitud.Text = ObtenerCodigo_SolicitudCompra();
                }
            }
            else
            {
                MessageBox.Show("La solictud de compra no se puede realizar porque no tiene datos que solicitar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
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
                        int TxtPrecioProdLim = int.Parse(TxtPrecioProd.Text.Replace("₡", ""));
                        //realizamos la multiplicacion 
                        int costo = int.Parse(TxtCantidad.Text) * TxtPrecioProdLim;
                        try
                        {
                            //mostramos el costo
                            TxtCostoTotal.Text = costo.ToString();
                            string PrespuestoSin = TxtMontuoDisponible.Text;
                            int result = int.Parse(PrespuestoSin.Substring(1));
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
            }


            private void DgvListaCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.ColumnIndex == DgvListaCompra.Columns["x"].Index && e.RowIndex >= 0)
                {
                    string PrespuestoSin = TxtMontuoDisponible.Text;
                    int result = int.Parse(PrespuestoSin.Substring(1));
                    int monto = int.Parse(DgvListaCompra.Rows[e.RowIndex].Cells[2].Value.ToString()) * int.Parse(DgvListaCompra.Rows[e.RowIndex].Cells[3].Value.ToString());
                    int montoActual = result + monto;
                    TxtMontuoDisponible.Text = montoActual.ToString();
                    int montoCompraActual = int.Parse(TxtTotalCompra.Text) - monto;
                    TxtTotalCompra.Text = montoCompraActual.ToString();

                    // Obtener la fila que se está eliminando
                    DataGridViewRow fila = DgvListaCompra.Rows[e.RowIndex];

                    // Eliminar la fila del DataGridView

                    DgvListaCompra.Rows.Remove(fila);

                }
            }

            //private void DgvListaCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
            //{

            //}

            private void FrmSolicitudCompra_Load(object sender, EventArgs e)
            {

                foreach (var item in PresupuestosList)
                {
                    //if (item.EstadoPresupuesto != true)
                    //{
                    //    CbListaPresupuestos.Items.Add(item.IdPresupuesto);
                    //}
                }
                CbListaPresupuestos.SelectedIndex = 0;
                //LLenamos el txt del codigo de la solicitud
                TxtSolicitud.Text = ObtenerCodigo_SolicitudCompra();


            }

            private void CbListaPresupuestos_SelectedIndexChanged(object sender, EventArgs e)
            {
                foreach (var item in PresupuestosList)
                {

                //    if (item.IdPresupuesto == CbListaPresupuestos.SelectedItem)

                ////if (item.IdPresupuesto == CbListaPresupuestos.SelectedItem)

                //    {
                //        TxtNombreProducto.Text = item.MontoPresupuesto.ToString();
                //    }
                }
                DgvListaCompra.Rows.Clear();
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
    
    }

}