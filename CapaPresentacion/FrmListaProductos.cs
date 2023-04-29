﻿using System;
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
    public partial class FrmListaProductos : Form
    {
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Instancia al formulario principal para acceder a los controles que se encuentran en el
        /// </summary>
        FrmAñadirProductos AñadirProductos = (FrmAñadirProductos)Application.OpenForms["FrmAñadirProductos"];
        //------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Instancia al formulario principal para acceder a los controles que se encuentran en el
        /// </summary>
        FrmSolicitudInsumos frmSolicitud = (FrmSolicitudInsumos)Application.OpenForms["FrmSolicitudInsumos"];
        //------------------------------------------------------------------------------------------


        public FrmListaProductos()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // METODO PASAR DATOS NO CAMBIAR
            if (e.RowIndex != -1)
            {
                int fila = e.RowIndex;
                //PASA LOS DATOS AL FORMULARIO AÑADIR PRODUCTOS
                AñadirProductos.TxtCodigoProducto.Text = DgvListaProductos.Rows[fila].Cells[0].Value.ToString();
                AñadirProductos.TxtNombreProducto.Text = DgvListaProductos.Rows[fila].Cells[1].Value.ToString();
                AñadirProductos.TxtCantidad.Text = DgvListaProductos.Rows[fila].Cells[2].Value.ToString();
                AñadirProductos.TxtDescripcion.Text = DgvListaProductos.Rows[fila].Cells[3].Value.ToString();


                AñadirProductos.BtnGuardar.Enabled = false;
                AñadirProductos.BtnModificar.Visible = true;
                AñadirProductos.BtnEliminar.Visible = true;
                AñadirProductos.TxtCantidad.Enabled = false;


                // PASA LOS DATOS AL FORMULARIO SOLICITUD DE INSUMOS
                frmSolicitud.TxtCodigoProcd.Text = DgvListaProductos.Rows[fila].Cells[0].Value.ToString();
                frmSolicitud.TxtNombreProduc.Text = DgvListaProductos.Rows[fila].Cells[2].Value.ToString();
                
                this.Close();
            }
        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {

        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtCodigo);
        }

        private void FrmListaProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
