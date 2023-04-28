using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmAñadirProductos : Form
    {
        
        public FrmAñadirProductos()
        {
            InitializeComponent();
        }

        private void BtnVerLista_Click(object sender, EventArgs e)
        {
            FrmListaProductos frmListaProductos = new FrmListaProductos();
            frmListaProductos.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //VALICIONES
            if (TxtCodigoProducto.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtCodigoProducto);

                if (TxtNombreProducto.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtNombreProducto);

                    if (TxtCantidad.TextLength > 0)
                    {
                        Validaciones.LimpiarError(TxtCantidad);

                        if (TxtDescripcion.TextLength > 0)
                        {
                            Validaciones.LimpiarError(TxtDescripcion);

                            //CODIGO PARA MODIFICAR Y ENVIAR A LA BASE DE DATOS********************



                            //LIMPIAR FORM
                            Validaciones.LimpiarFormulario(flowLayoutPanel2);
                        }
                        else
                        {
                            Validaciones.MostarError(TxtDescripcion, "Debes ingresar la drescripcion del producto");
                        }

                    }
                    else
                    {
                        Validaciones.MostarError(TxtCantidad, "Debes ingresar cantidad de producto");
                    }

                }
                else
                {
                    Validaciones.MostarError(TxtNombreProducto, "Debes ingresar el nombre del producto");
                }

            }
            else
            {
                Validaciones.MostarError(TxtCodigoProducto, "Debes ingresar el codigo del producto");
            }

            //OCULTAR LOS BOTONES DE NUEVO
            BtnModificar.Visible = false;
            BtnEliminar.Visible = false;
            BtnGuardar.Enabled = true;
            TxtCantidad.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //VALICIONES
            if (TxtCodigoProducto.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtCodigoProducto);

                if (TxtNombreProducto.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtNombreProducto);

                    if (TxtCantidad.TextLength > 0)
                    {
                        Validaciones.LimpiarError(TxtCantidad);

                        if (TxtDescripcion.TextLength > 0)
                        {
                            Validaciones.LimpiarError(TxtDescripcion);

                            //CODIGO PARA ELIMINAR Y ENVIAR A LA BASE DE DATOS********************



                            //LIMPIAR FORM
                            Validaciones.LimpiarFormulario(flowLayoutPanel2);
                        }
                        else
                        {
                            Validaciones.MostarError(TxtDescripcion, "Debes ingresar la drescripcion del producto");
                        }

                    }
                    else
                    {
                        Validaciones.MostarError(TxtCantidad, "Debes ingresar cantidad de producto");
                    }

                }
                else
                {
                    Validaciones.MostarError(TxtNombreProducto, "Debes ingresar el nombre del producto");
                }

            }
            else
            {
                Validaciones.MostarError(TxtCodigoProducto, "Debes ingresar el codigo del producto");
            }


            //OCULTAR LOS BOTONES DE NUEVO
            BtnModificar.Visible = false;
            BtnEliminar.Visible = false;
            BtnGuardar.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //VALICIONES
            if(TxtCodigoProducto.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtCodigoProducto);

                if (TxtNombreProducto.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtNombreProducto);

                    if (TxtCantidad.TextLength > 0)
                    {
                        Validaciones.LimpiarError(TxtCantidad);

                        if (TxtDescripcion.TextLength > 0)
                        {
                            Validaciones.LimpiarError(TxtDescripcion);

                            //CODIGO PARA GUARDAR Y ENVIAR A LA BASE DE DATOS********************



                            //LIMPIAR FORM
                            Validaciones.LimpiarFormulario(flowLayoutPanel2);
                        }
                        else
                        {
                            Validaciones.MostarError(TxtDescripcion, "Debes ingresar la drescripcion del producto");
                        }

                    }
                    else
                    {
                        Validaciones.MostarError(TxtCantidad, "Debes ingresar cantidad de producto");
                    }

                }
                else
                {
                    Validaciones.MostarError(TxtNombreProducto, "Debes ingresar el nombre del producto");
                }

            }
            else
            {
                Validaciones.MostarError(TxtCodigoProducto, "Debes ingresar el codigo del producto");
            }

        }

        private void TxtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtCodigoProducto);
            
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtCantidad);
        }
    }
}
