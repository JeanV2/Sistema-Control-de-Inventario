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
using Utilidades;

namespace CapaPresentacion
{
    public partial class FrmAñadirProductos : Form
    {
        private void MostrarDataGridView()
        {
            if (PanelDataGrid.Visible == false)
            {
                PanelDataGrid.Visible = true;
                LblBuscar.Visible = true;
                TxtBuscarPorPresupuesto.Visible = true;
                BtnFiltrar.Visible = true;
            }
            else
            {
                PanelDataGrid.Visible = false;
                LblBuscar.Visible = false;
                TxtBuscarPorPresupuesto.Visible = false;
                BtnFiltrar.Visible = false;
                TxtBuscarPorPresupuesto.ResetText();
            }
        }
        //entidad
        TbProducto producto = new TbProducto();

        NegociosProductos NegProduct = new NegociosProductos();

        String CodigoArmado = "";

        public FrmAñadirProductos()
        {
            InitializeComponent();
        }

        


        private void BtnVerLista_Click(object sender, EventArgs e)
        {
            //CREAR CODIGO PARA REFRESCAR EL DATAGRIDVIEW ANTES DEL METODO Mostrar DataGridView

            MostrarDataGridView();
        }

        

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //VALICIONES
            //if (TxtCodigoProducto.TextLength > 0)
            //{
            //    Validaciones.LimpiarError(TxtCodigoProducto);

            //    if (TxtNombreProducto.TextLength > 0)
            //    {
            //        Validaciones.LimpiarError(TxtNombreProducto);

            //        if (TxtCantidad.TextLength > 0)
            //        {
            //            Validaciones.LimpiarError(TxtCantidad);
            //            if (TxtCosto.TextLength > 0)
            //            {
            //                Validaciones.LimpiarError(TxtCosto);
            //                if (TxtDescripcion.TextLength > 0)
            //                {
            //                    Validaciones.LimpiarError(TxtDescripcion);

            //                    //CODIGO PARA MODIFICAR Y ENVIAR A LA BASE DE DATOS********************

            //                    producto.CodProducto = TxtCodigoProducto.Text;
            //                    producto.NombreProducto = TxtNombreProducto.Text;
            //                    producto.CostoProducto = TxtCosto.Text;
            //                    producto.Descripcion = TxtDescripcion.Text;
            //                    producto.CantidadProducto = int.Parse(TxtCantidad.Text.Trim());
            //                    //producto.Estado = true;
            //                    if (NegProduct.ModificarProduct(producto))
            //                    {
            //                        MessageBox.Show("Producto modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //                        //LIMPIAR FORM
            //                        Validaciones.LimpiarFormulario(flowLayoutPanel2);
            //                        //OCULTAR LOS BOTONES DE NUEVO
            //                        BtnModificar.Visible = false;
            //                        BtnEliminar.Visible = false;
            //                        BtnGuardar.Enabled = true;
            //                        TxtCantidad.Enabled = true;
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("Error al modificar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                    }


            //                }
            //                else
            //                {
            //                    Validaciones.MostarError(TxtDescripcion, "Debes ingresar la drescripcion del producto");
            //                }

            //            }
            //            else
            //            {
            //                Validaciones.MostarError(TxtCantidad, "Debes ingresar cantidad de producto");
            //            }
            //        }
            //        else
            //        {
            //            Validaciones.MostarError(TxtCosto, "Debes Digitar el costo del producto");
            //        }
            //    }
            //    else
            //    {
            //        Validaciones.MostarError(TxtNombreProducto, "Debes ingresar el nombre del producto");
            //    }

            //}
            //else
            //{
            //    Validaciones.MostarError(TxtCodigoProducto, "Debes ingresar el codigo del producto");
            //}


        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ////VALICIONES
            //if (TxtCodigoProducto.TextLength > 0)
            //{
            //    Validaciones.LimpiarError(TxtCodigoProducto);

            //    if (TxtNombreProducto.TextLength > 0)
            //    {
            //        Validaciones.LimpiarError(TxtNombreProducto);

            //        if (TxtCantidad.TextLength > 0)
            //        {
            //            Validaciones.LimpiarError(TxtCantidad);

            //            if (TxtDescripcion.TextLength > 0)
            //            {
            //                Validaciones.LimpiarError(TxtDescripcion);

            //                //CODIGO PARA ELIMINAR Y ENVIAR A LA BASE DE DATOS********************
            //                producto.CodProducto = TxtCodigoProducto.Text;
            //                //producto.Estado = false;

            //                if (NegProduct.EliminarProduct(producto))
            //                {
            //                    MessageBox.Show("Producto eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                    //LIMPIAR FORM
            //                    Validaciones.LimpiarFormulario(flowLayoutPanel2);
            //                    //OCULTAR LOS BOTONES DE NUEVO
            //                    BtnModificar.Visible = false;
            //                    BtnEliminar.Visible = false;
            //                    BtnGuardar.Enabled = true;
            //                    TxtCodigoProducto.ReadOnly = false;
            //                    TxtCodigoProducto.Focus();
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Error al eliminar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                }



            //            }
            //            else
            //            {
            //                Validaciones.MostarError(TxtDescripcion, "Debes ingresar la drescripcion del producto");
            //            }

            //        }
            //        else
            //        {
            //            Validaciones.MostarError(TxtCantidad, "Debes ingresar cantidad de producto");
            //        }

            //    }
            //    else
            //    {
            //        Validaciones.MostarError(TxtNombreProducto, "Debes ingresar el nombre del producto");
            //    }

            //}
            //else
            //{
            //    Validaciones.MostarError(TxtCodigoProducto, "Debes ingresar el codigo del producto");
            //}



        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ////VALICIONES
            //if (TxtCodigoProducto.TextLength > 0)
            //{
            //    Validaciones.LimpiarError(TxtCodigoProducto);

            //    if (TxtNombreProducto.TextLength > 0)
            //    {
            //        Validaciones.LimpiarError(TxtNombreProducto);

            //        if (TxtCantidad.TextLength > 0)
            //        {
            //            Validaciones.LimpiarError(TxtCantidad);

            //            if (TxtCosto.TextLength > 0)
            //            {
            //                Validaciones.LimpiarError(TxtCosto);
            //                if (TxtDescripcion.TextLength > 0)
            //                {
            //                    Validaciones.LimpiarError(TxtDescripcion);

            //                    //CODIGO PARA GUARDAR Y ENVIAR A LA BASE DE DATOS********************
            //                    producto.CodProducto = TxtCodigoProducto.Text;
            //                    producto.NombreProducto = TxtNombreProducto.Text;
            //                    producto.CostoProducto = TxtCosto.Text.Replace("₡", "");
            //                    producto.Descripcion = TxtDescripcion.Text;
            //                    producto.CantidadProducto = int.Parse(TxtCantidad.Text.Trim());
            //                    //producto.Estado = true;

            //                    if (NegProduct.GuardarProduct(producto))
            //                    {
            //                        MessageBox.Show("Producto Guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //                        //LIMPIAR FORM
            //                        Validaciones.LimpiarFormulario(flowLayoutPanel2);
            //                        TxtCodigoProducto.ReadOnly = false;
            //                        TxtCodigoProducto.Focus();
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("Error al guardar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                    }

            //                }
            //                else
            //                {
            //                    Validaciones.MostarError(TxtDescripcion, "Debes ingresar la drescripcion del producto");
            //                }
            //            }
            //            else
            //            {
            //                Validaciones.MostarError(TxtCosto, "Debes Digitar el costo del producto");
            //            }

            //        }
            //        else
            //        {
            //            Validaciones.MostarError(TxtCantidad, "Debes ingresar cantidad de producto");
            //        }

            //    }
            //    else
            //    {
            //        Validaciones.MostarError(TxtNombreProducto, "Debes ingresar el nombre del producto");
            //    }

            //}
            //else
            //{
            //    Validaciones.MostarError(TxtCodigoProducto, "Debes ingresar el codigo del producto");
            //}

        }






        private void TxtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void TxtCodigoPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtCodigoPresupuesto);
        }

        private void TxtSubFamilia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtSubFamilia);
        }

        private void TxtSubFam_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtSubFam_Producto);
        }

        private void TxtInventRequerido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtInventRequerido);
        }

        private void TxtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_Decimales_y_Borrar(e, TxtPrecioProducto);
        }

        private void TxtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtExistencia);
        }

        private void TxtSubFam_Producto_Leave(object sender, EventArgs e)
        {
            if (TxtCodigoPresupuesto.Text!= string.Empty)
            {
                Validaciones.LimpiarError(TxtCodigoPresupuesto);
                
                CodigoArmado = TxtCodigoPresupuesto.Text.Trim();

                if (TxtSubFamilia.Text != string.Empty)
                {
                    Validaciones.LimpiarError(TxtSubFamilia);

                    CodigoArmado = CodigoArmado + "-" + TxtSubFamilia.Text.Trim();

                    if (TxtSubFam_Producto.Text != string.Empty)
                    {
                        Validaciones.LimpiarError(TxtSubFam_Producto);

                        CodigoArmado = CodigoArmado + "-" + TxtSubFam_Producto.Text.Trim();

                        TxtCodigoProducto.Text = CodigoArmado;

                        //CodigoArmado = "";
                    }
                    else
                    {
                        Validaciones.MostarError(TxtSubFam_Producto, "Debes Ingresar el Codigo de la Sub Familia");
                    }
                }
                else
                {
                    Validaciones.MostarError(TxtSubFamilia, "Debes Ingresar el Codigo de la Sub Familia");
                }
            }
            else
            {
                Validaciones.MostarError(TxtCodigoPresupuesto, "Debes Ingresar el Codigo de Presupuesto");
            }
        }

        private void DgvListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                int fila = e.RowIndex;

                TxtCodigoPresupuesto.Text = DgvListaProductos.Rows[fila].Cells[0].Value.ToString();
                TxtSubFamilia.Text = DgvListaProductos.Rows[fila].Cells[1].Value.ToString();
                TxtSubFam_Producto.Text = DgvListaProductos.Rows[fila].Cells[2].Value.ToString();
                TxtCodigoProducto.Text = DgvListaProductos.Rows[fila].Cells[3].Value.ToString();
                TxtNombreProducto.Text = DgvListaProductos.Rows[fila].Cells[4].Value.ToString();
                if (DgvListaProductos.Rows[fila].Cells[5].Value.ToString()== "Unidad")
                {
                    CbUnidadMedida.SelectedIndex = 0;
                }
                if (DgvListaProductos.Rows[fila].Cells[5].Value.ToString() == "Kilogramo")
                {
                    CbUnidadMedida.SelectedIndex = 1;
                }

                TxtInventRequerido.Text = DgvListaProductos.Rows[fila].Cells[6].Value.ToString();
                TxtPrecioProducto.Text = DgvListaProductos.Rows[fila].Cells[7].Value.ToString();
                TxtCostoTotal.Text = DgvListaProductos.Rows[fila].Cells[8].Value.ToString();
                TxtExistencia.Text = DgvListaProductos.Rows[fila].Cells[9].Value.ToString();
                MostrarDataGridView();
            }
        }

        private void TxtPrecioProducto_TextChanged(object sender, EventArgs e)
        {
            Validaciones.AgregarSimboloColones(TxtPrecioProducto);
        }

        private void TxtPrecioProducto_Leave(object sender, EventArgs e)
        {
            int InventarioRequerido = Convert.ToInt32(TxtInventRequerido.Text);
            double Precio = Convert.ToDouble(TxtPrecioProducto.Text.Replace("₡", ""));
            double CostoTotal = InventarioRequerido * Precio;
            TxtCostoTotal.Text= CostoTotal.ToString();
        }

        private void FrmAñadirProductos_Load(object sender, EventArgs e)
        {
            CbUnidadMedida.DataSource = Enum.GetValues(typeof(Enums.Unidad_Medida));
          
        }

        private void TxtCostoTotal_TextChanged(object sender, EventArgs e)
        {
            Validaciones.AgregarSimboloColones(TxtCostoTotal);
        }
    }
}
