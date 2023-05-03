using CapaEntidades;
using CapaNegocios;
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

        //entidad
        TbProducto producto = new TbProducto();

        NegociosProductos NegProduct = new NegociosProductos();


        private void BtnVerLista_Click(object sender, EventArgs e)
        {
            FrmListaProductos frmListaProductos = new FrmListaProductos(this);
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
                        if (TxtCosto.TextLength > 0)
                        {
                            Validaciones.LimpiarError(TxtCosto);
                            if (TxtDescripcion.TextLength > 0)
                            {
                                Validaciones.LimpiarError(TxtDescripcion);

                                //CODIGO PARA MODIFICAR Y ENVIAR A LA BASE DE DATOS********************

                                producto.CodProducto = TxtCodigoProducto.Text;
                                producto.NombreProducto = TxtNombreProducto.Text;
                                producto.CostoProducto = TxtCosto.Text;
                                producto.Descripcion = TxtDescripcion.Text;
                                producto.CantidadProducto = int.Parse(TxtCantidad.Text.Trim());
                                producto.Estado = true;
                                if (NegProduct.ModificarProduct(producto))
                                {
                                    MessageBox.Show("Producto modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    //LIMPIAR FORM
                                    Validaciones.LimpiarFormulario(flowLayoutPanel2);
                                    //OCULTAR LOS BOTONES DE NUEVO
                                    BtnModificar.Visible = false;
                                    BtnEliminar.Visible = false;
                                    BtnGuardar.Enabled = true;
                                    TxtCantidad.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("Error al modificar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }


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
                        Validaciones.MostarError(TxtCosto, "Debes Digitar el costo del producto");
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
                            producto.CodProducto = TxtCodigoProducto.Text;
                            producto.Estado = false;

                            if (NegProduct.EliminarProduct(producto))
                            {
                                MessageBox.Show("Producto eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                //LIMPIAR FORM
                                Validaciones.LimpiarFormulario(flowLayoutPanel2);
                                //OCULTAR LOS BOTONES DE NUEVO
                                BtnModificar.Visible = false;
                                BtnEliminar.Visible = false;
                                BtnGuardar.Enabled = true;
                                TxtCodigoProducto.ReadOnly = false;
                                TxtCodigoProducto.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }



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

        private void BtnGuardar_Click(object sender, EventArgs e)
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

                        if (TxtCosto.TextLength > 0)
                        {
                            Validaciones.LimpiarError(TxtCosto);
                            if (TxtDescripcion.TextLength > 0)
                            {
                                Validaciones.LimpiarError(TxtDescripcion);

                                //CODIGO PARA GUARDAR Y ENVIAR A LA BASE DE DATOS********************
                                producto.CodProducto = TxtCodigoProducto.Text;
                                producto.NombreProducto = TxtNombreProducto.Text;
                                producto.CostoProducto = TxtCosto.Text.Replace("₡", "");
                                producto.Descripcion = TxtDescripcion.Text;
                                producto.CantidadProducto = int.Parse(TxtCantidad.Text.Trim());
                                producto.Estado = true;

                                if (NegProduct.GuardarProduct(producto))
                                {
                                    MessageBox.Show("Producto Guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    //LIMPIAR FORM
                                    Validaciones.LimpiarFormulario(flowLayoutPanel2);
                                    TxtCodigoProducto.ReadOnly = false;
                                    TxtCodigoProducto.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("Error al guardar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }

                            }
                            else
                            {
                                Validaciones.MostarError(TxtDescripcion, "Debes ingresar la drescripcion del producto");
                            }
                        }
                        else
                        {
                            Validaciones.MostarError(TxtCosto, "Debes Digitar el costo del producto");
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

        private void TxtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_Decimales_y_Borrar(e, TxtCosto);
        }

        private void TxtCosto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCosto.Text))
            {
                if (!TxtCosto.Text.StartsWith("₡"))
                {
                    TxtCosto.Text = "₡" + TxtCosto.Text;
                    TxtCosto.SelectionStart = TxtCosto.Text.Length;

                }
            }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras_y_Numeros(e, TxtDescripcion);
        }

        private void TxtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras_y_Numeros(e, TxtNombreProducto);
        }

        private void TxtCodigoProducto_Leave(object sender, EventArgs e)
        {
            producto.CodProducto = TxtCodigoProducto.Text;
            if (NegProduct.ExisteProducto(producto))
            {
                MessageBox.Show("Este Codigo ya se encuentra registrado");
            }
        }
    }
}
