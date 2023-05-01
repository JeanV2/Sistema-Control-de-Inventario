using CapaEntidades;
using System;
using System.Collections;
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
    public partial class FrmSolicitudCompra : Form
    {
        public int Presupuesto = 1000000;
        public string idSolicitud = "0001";
        public FrmSolicitudCompra()
        {
            InitializeComponent();
            //SET DATETIMEPICKER
            DtpFechaSolicitud.MinDate= DateTime.Today;
            TxtPresupuesto.Text = Presupuesto.ToString(); ;
            TxtSolicitud.Text = idSolicitud;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmListaProductosSolicituCompra frmListaProductos = new FrmListaProductosSolicituCompra();
            frmListaProductos.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //VALIDACIONES
            if (TxtPresupuesto.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtPresupuesto);

                //SOLICITUD
                if (TxtSolicitud.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtSolicitud);

                    //CANTIDAD
                    if (TxtCantidad.TextLength > 0)
                    {
                        Validaciones.LimpiarError(TxtCantidad);

                        //CODIGO PRODUCTO
                        if (TxtCodigoProd.TextLength > 0)
                        {
                            Validaciones.LimpiarError(TxtCodigoProd);

                            //COSTO TOTAL
                            if (TxtCostoTotal.TextLength > 0)
                            {
                                Validaciones.LimpiarError(TxtCostoTotal);

                                //PRECIO PRODUCTO
                                if (TxtPrecioProd.TextLength > 0)
                                {
                                    Validaciones.LimpiarError(TxtPrecioProd);



                                    //agregamos el producto al datagridview
                                    //limpiamos el txt de precio producto para que no contenga caracteres invalidos
                                    int TxtPrecioProdLim = int.Parse(TxtPrecioProd.Text.Replace("₡", ""));
                                    int row= DgvListaCompra.Rows.Add();
                                        DgvListaCompra.Rows[row].Cells[0].Value = TxtSolicitud.Text;
                                        DgvListaCompra.Rows[row].Cells[1].Value = TxtCodigoProd.Text;
                                        DgvListaCompra.Rows[row].Cells[2].Value = TxtCantidad.Text;
                                    DgvListaCompra.Rows[row].Cells[3].Value = TxtPrecioProdLim;


                                    //LIMPIAR FORM
                                    Validaciones.LimpiarFormulario(flowLayoutPanel4);
                                    //actualizamos el monto total
                                    int CostoFinal = 0;
                                    int CostoAñadir = 0;
                                    for (int i = 0; i < DgvListaCompra.RowCount; i++)
                                    {
                                        if (DgvListaCompra.Rows[i].Cells[0].Value!=null)
                                        {
                                            CostoAñadir = int.Parse(DgvListaCompra.Rows[i].Cells[3].Value.ToString()) * int.Parse(DgvListaCompra.Rows[i].Cells[2].Value.ToString());
                                            CostoFinal = CostoFinal + CostoAñadir;
                                        }
                                   
                                    }
                                    TxtTotalCompra.Text=CostoFinal.ToString();
                                    //realizamos el rebajo al presupuesto
                                    Presupuesto = 1000000;
                                    Presupuesto = Presupuesto - CostoFinal;
                                    //actualizamos el presupuesto
                                    TxtPresupuesto.Text= Presupuesto.ToString();
                                    TxtSolicitud.Text = idSolicitud;
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
                            Validaciones.MostarError(TxtCodigoProd, "Ingresar código de producto");
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
                Validaciones.MostarError(TxtPresupuesto, "Debes ingresar el monto del presupuesto");
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

        private void TxtCodigoProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras_y_Numeros(e, TxtCodigoProd);
        }

        private void TxtPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras_y_Numeros(e, TxtPresupuesto);
        }

        private void TxtSolicitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras_y_Numeros(e, TxtSolicitud);
        }

        private void TxtPrecioProd_TextChanged(object sender, EventArgs e)
        {
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
            // CODIGO PARA GUARDAR



            //LIMPIAR FORM
            Validaciones.LimpiarFormulario(flowLayoutPanel4);
            //CLEAR DATE TIME PICKER
            DtpFechaSolicitud.Value = DateTime.Today;
            //CLEAR DATA GRID VIEW
            // -- ACA VA EL CODIGO PARA LIMPIAR EL DATA GRIG VIEW
        }
     
        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            //validamos que el txt no este vacio
            if (TxtCantidad.Text!=string.Empty)
            {
                //si txtcantidad es igual a 0 costo total sera igual a 0
                if (TxtCantidad.Text=="0")
                {
                    TxtCostoTotal.Text = "0";
                }
                //caso contrario se multipla el precio del producto por la cantidad
                else
                {
                    //limpiamos el txt de precio producto para que no contenga caracteres invalidos
                    int TxtPrecioProdLim = int.Parse(TxtPrecioProd.Text.Replace("₡",""));
                    //realizamos la multiplicacion 
                    int costo = int.Parse(TxtCantidad.Text) * TxtPrecioProdLim;
                    //mostramos el costo
                    TxtCostoTotal.Text = costo.ToString() ;
                }
             
            }
        }
    }
}
