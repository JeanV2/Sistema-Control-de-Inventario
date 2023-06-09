﻿using CapaEntidades;
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
        public FrmAñadirProductos()
        {
            InitializeComponent();
        }
        //entidad
        TbProducto producto = new TbProducto();

        NegociosProductos NegProduct = new NegociosProductos();
        NegocioPresupuestos NegPresupuesto = new NegocioPresupuestos();
        //Lista
        List<TbProducto> ListProducto;
        List<TbPresupuesto> ListPresupuesto;

        String CodigoArmado = "";

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

        private async void BtnVerLista_Click(object sender, EventArgs e)
        {
            //CREAR CODIGO PARA REFRESCAR EL DATAGRIDVIEW ANTES DEL METODO Mostrar DataGridView
            ListProducto = await NegProduct.ListProduct();
            if (ListProducto != null)
            {
                RefreshDatos(ListProducto);
                MostrarDataGridView();
            }
            else
            {
                MessageBox.Show("No hay datos");
            }

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

                    if (TxtInventRequerido.TextLength > 0)
                    {
                        Validaciones.LimpiarError(TxtInventRequerido);

                        if (TxtPrecioProducto.TextLength > 0)
                        {
                            Validaciones.LimpiarError(TxtPrecioProducto);

                            if (TxtExistencia.TextLength > 0)
                            {
                                Validaciones.LimpiarError(TxtExistencia);

                                //CODIGO PARA MODIFICAR Y ENVIAR A LA BASE DE DATOS********************
                                producto.CodProducto = TxtCodigoProducto.Text;
                                producto.CFamilia = TxtCodigoPresupuesto.Text;
                                producto.CSubFamilia = TxtSubFamilia.Text;
                                producto.NumProducto = TxtSubFam_Producto.Text;
                                producto.CFUnidadMedida = CbUnidadMedida.Text;
                                producto.DesResumida = TxtNombreProducto.Text;
                                producto.MUltCosto = Convert.ToDouble(TxtPrecioProducto.Text.Replace("₡", ""));
                                producto.InventarioRequerido = int.Parse(TxtInventRequerido.Text);
                                producto.InventarioExistente = int.Parse(TxtExistencia.Text);
                                producto.CostoTotal = Convert.ToDouble(TxtCostoTotal.Text.Replace("₡", ""));

                                if (NegProduct.ModificarProduct(producto))
                                {
                                    MessageBox.Show("Producto modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    //LIMPIAR FORM
                                    Validaciones.LimpiarFormulario(tableLayoutPanel1);
                                    TxtCodigoProducto.ReadOnly = false;
                                    TxtCodigoProducto.Focus();
                                    BtnEliminar.Visible = false;
                                    BtnGuardar.Visible = true;
                                    BtnModificar.Visible = false;
                                }
                                else
                                {
                                    MessageBox.Show("Error al modificar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                Validaciones.MostarError(TxtExistencia, "Debes ingresar la existencia del producto");
                            }

                        }
                        else
                        {
                            Validaciones.MostarError(TxtPrecioProducto, "Debes Digitar el costo del producto");
                        }

                    }
                    else
                    {
                        Validaciones.MostarError(TxtInventRequerido, "Debes ingresar cantidad de producto");
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
            ////VALICIONES
            if (TxtCodigoProducto.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtCodigoProducto);

                if (TxtNombreProducto.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtNombreProducto);

                    if (TxtInventRequerido.TextLength > 0)
                    {
                        Validaciones.LimpiarError(TxtInventRequerido);

                        if (TxtPrecioProducto.TextLength > 0)
                        {
                            Validaciones.LimpiarError(TxtPrecioProducto);

                            if (TxtExistencia.TextLength > 0)
                            {
                                Validaciones.LimpiarError(TxtExistencia);

                                //CODIGO PARA Eliminar Y ENVIAR A LA BASE DE DATOS********************
                                producto.CodProducto = TxtCodigoProducto.Text;
                                producto.EstadoProD = false;
                                if (NegProduct.EliminarProduct(producto))
                                {
                                    MessageBox.Show("Producto eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    //LIMPIAR FORM
                                    Validaciones.LimpiarFormulario(tableLayoutPanel1);
                                    TxtCodigoProducto.ReadOnly = false;
                                    TxtCodigoProducto.Focus();
                                    BtnEliminar.Visible = false;
                                    BtnGuardar.Visible = true;
                                    BtnModificar.Visible = false;
                                }
                                else
                                {
                                    MessageBox.Show("Error al eliminar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                Validaciones.MostarError(TxtExistencia, "Debes ingresar la existencia del producto");
                            }

                        }
                        else
                        {
                            Validaciones.MostarError(TxtPrecioProducto, "Debes Digitar el costo del producto");
                        }

                    }
                    else
                    {
                        Validaciones.MostarError(TxtInventRequerido, "Debes ingresar cantidad de producto");
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
            ////VALICIONES
            if (TxtCodigoProducto.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtCodigoProducto);

                if (TxtNombreProducto.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtNombreProducto);

                    if (TxtInventRequerido.TextLength > 0)
                    {
                        Validaciones.LimpiarError(TxtInventRequerido);

                        if (TxtPrecioProducto.TextLength > 0)
                        {
                            Validaciones.LimpiarError(TxtPrecioProducto);
                            if (TxtInventRequerido.TextLength > 0)
                            {
                                Validaciones.LimpiarError(TxtInventRequerido);

                                if (TxtExistencia.TextLength > 0)
                                {
                                    Validaciones.LimpiarError(TxtExistencia);

                                    if (ExistePresupuesto()) 
                                    {
                                        producto.CodProducto = TxtCodigoProducto.Text;

                                        if (NegProduct.ExisteProducto(producto))
                                        {
                                            MessageBox.Show("Codigo ya se encuentrado registrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }
                                        else
                                        {
                                            GuardarProducto();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Codigo de Presupuesto no esta registrado, por favor verificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                   
                                }
                                else
                                {
                                    Validaciones.MostarError(TxtExistencia, "Debes ingresar la drescripcion del producto");
                                }
                            }
                            else
                            {
                                Validaciones.MostarError(TxtInventRequerido, "Debes ingresar la drescripcion del producto");
                            }
                        }
                        else
                        {
                            Validaciones.MostarError(TxtPrecioProducto, "Debes Digitar el costo del producto");
                        }

                    }
                    else
                    {
                        Validaciones.MostarError(TxtInventRequerido, "Debes ingresar cantidad de producto");
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
  
        private void GuardarProducto()
        {
            //CODIGO PARA GUARDAR Y ENVIAR A LA BASE DE DATOS********************
            producto.CodProducto = TxtCodigoProducto.Text;
            producto.CFamilia = TxtCodigoPresupuesto.Text;
            producto.CSubFamilia = TxtSubFamilia.Text;
            producto.NumProducto = TxtSubFam_Producto.Text;
            producto.CFUnidadMedida = CbUnidadMedida.Text;
            producto.DesResumida = TxtNombreProducto.Text;
            producto.MUltCosto = Convert.ToDouble(TxtPrecioProducto.Text.Replace("₡", ""));
            producto.InventarioRequerido = int.Parse(TxtInventRequerido.Text);
            producto.InventarioExistente = int.Parse(TxtExistencia.Text);
            producto.CostoTotal = Convert.ToDouble(TxtCostoTotal.Text.Replace("₡", ""));
            producto.EstadoProD = true;

            if (NegProduct.GuardarProduct(producto))
            {
                MessageBox.Show("Producto Guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //LIMPIAR FORM
                Validaciones.LimpiarFormulario(tableLayoutPanel1);
                TxtCodigoProducto.ReadOnly = false;
                TxtCodigoProducto.Focus();
            }
            else
            {
                MessageBox.Show("Error al guardar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            if (TxtCodigoPresupuesto.Text != string.Empty)
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
        /// <summary>
        /// Verifica que el presupuesto ingresado existe
        /// </summary>
        /// <returns>true si existe,false si no</returns>
        private bool ExistePresupuesto()
        {
            ListPresupuesto = NegPresupuesto.ListaPresupuestos();
            bool Existe = false;

            foreach (TbPresupuesto pres in ListPresupuesto)
            {
                if (pres.numeroCuenta.Equals(TxtCodigoPresupuesto.Text))
                {
                    Existe = true;
                    break;
                }
                else
                {
                    Existe = false;
                }
            }
            return Existe;
        }
        //Filtrar por presupuesto
        private  async void BtnFiltrar_Click(object sender, EventArgs e)
        {
            //buscar
             List<TbProducto> listaAux;

            if (TxtBuscarPorPresupuesto.Text != string.Empty)
            {

                listaAux = ListProducto.Where(x => x.CFamilia==TxtBuscarPorPresupuesto.Text).ToList();
                TxtBuscarCodigoProd.Clear();
            }
            else if (TxtBuscarCodigoProd.Text!=string.Empty)
            {
                listaAux = ListProducto.Where(x => x.CodProducto==TxtBuscarCodigoProd.Text).ToList();
                TxtBuscarCodigoProd.Clear();
            }else if (TxtBuscarPorPresupuesto.Text!= string.Empty && TxtBuscarCodigoProd.Text!= string.Empty)
            {
                listaAux = ListProducto.Where(x => x.CodProducto == TxtBuscarCodigoProd.Text && x.CFamilia==TxtBuscarPorPresupuesto.Text).ToList();
                TxtBuscarCodigoProd.Clear();
                TxtBuscarCodigoProd.Clear();
            }
            else
            {
                ListProducto = await NegProduct.ListProduct();
                listaAux = ListProducto;
            }
            RefreshDatos(listaAux);

        }
        //Refrescar DataGridView
        private void RefreshDatos(List<TbProducto> listaProductos)
        {
            DgvListaProductos.Rows.Clear();

            foreach (TbProducto tbProducto in listaProductos)
            {
                int nr = DgvListaProductos.Rows.Add();

                DgvListaProductos.Rows[nr].Cells[0].Value = tbProducto.CFamilia;
                DgvListaProductos.Rows[nr].Cells[1].Value = tbProducto.CSubFamilia;
                DgvListaProductos.Rows[nr].Cells[2].Value = tbProducto.NumProducto;
                DgvListaProductos.Rows[nr].Cells[3].Value = tbProducto.CodProducto;
                DgvListaProductos.Rows[nr].Cells[4].Value = tbProducto.DesResumida;
                DgvListaProductos.Rows[nr].Cells[5].Value = tbProducto.CFUnidadMedida;
                DgvListaProductos.Rows[nr].Cells[6].Value = tbProducto.InventarioRequerido;
                DgvListaProductos.Rows[nr].Cells[7].Value = tbProducto.MUltCosto;
                DgvListaProductos.Rows[nr].Cells[8].Value = tbProducto.InventarioRequerido* tbProducto.MUltCosto;
                DgvListaProductos.Rows[nr].Cells[9].Value = tbProducto.InventarioExistente;
            }
        }
        /// <summary>
        /// al hacer doble clik los datos se cargan para poder editar o eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int fila = e.RowIndex;

                TxtCodigoPresupuesto.Text = DgvListaProductos.Rows[fila].Cells[0].Value.ToString();
                TxtSubFamilia.Text = DgvListaProductos.Rows[fila].Cells[1].Value.ToString();
                TxtSubFam_Producto.Text = DgvListaProductos.Rows[fila].Cells[2].Value.ToString();
                TxtCodigoProducto.Text = DgvListaProductos.Rows[fila].Cells[3].Value.ToString();
                TxtNombreProducto.Text = DgvListaProductos.Rows[fila].Cells[4].Value.ToString();
                if (DgvListaProductos.Rows[fila].Cells[5].Value.ToString() == "Unidad")
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
                BtnEliminar.Visible = true;
                BtnGuardar.Visible = false;
                BtnModificar.Visible = true;
            }
        }

        private void TxtPrecioProducto_TextChanged(object sender, EventArgs e)
        {
            Validaciones.AgregarSimboloColones(TxtPrecioProducto);
        }

        private void TxtPrecioProducto_Leave(object sender, EventArgs e)
        {
            if (TxtInventRequerido.Text!=string.Empty)
            {
                int InventarioRequerido = Convert.ToInt32(TxtInventRequerido.Text);
                double Precio = Convert.ToDouble(TxtPrecioProducto.Text.Replace("₡", ""));
                double CostoTotal = InventarioRequerido * Precio;
                TxtCostoTotal.Text = CostoTotal.ToString().Replace(" ", "₡");
            }


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
