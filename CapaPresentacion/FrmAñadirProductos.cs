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
            //CODIGO PARA ACTUALIZAR AL FINAL OCULTAR LOS BOTONES DE NUEVO
            BtnModificar.Visible = false;
            BtnEliminar.Visible = false;
            BtnGuardar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //CODIGO PARA eLIMINAR AL FINAL OCULTAR LOS BOTONES DE NUEVO
            BtnModificar.Visible = false;
            BtnEliminar.Visible = false;
            BtnGuardar.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //CODIGO PARA GUARDAR

            Validaciones.LimpiarFormulario(flowLayoutPanel2);
        }
    }
}
