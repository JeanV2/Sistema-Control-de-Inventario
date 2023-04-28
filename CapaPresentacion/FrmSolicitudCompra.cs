using System;
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
        public FrmSolicitudCompra()
        {
            InitializeComponent();
            //SET DATETIMEPICKER
            DtpFechaSolicitud.MinDate= DateTime.Today;
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



                                    //CODE FOR ADDING ********************


                                    //LIMPIAR FORM
                                    Validaciones.LimpiarFormulario(flowLayoutPanel4);
                                    //CLEAR DATE TIME PICKER
                                    DtpFechaSolicitud.Value = DateTime.Today;

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
            Validaciones.Numeros_y_Borrar(e, TxtCodigoProd);
        }

        private void TxtPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtPresupuesto);
        }
    }
}
