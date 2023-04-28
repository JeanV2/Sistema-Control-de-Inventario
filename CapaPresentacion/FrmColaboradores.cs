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
    public partial class FrmColaboradores : Form
    {
        public FrmColaboradores()
        {
            InitializeComponent();
        }

        private void BtnGuardarColaborador_Click(object sender, EventArgs e)
        {
            //CODIGO PARA GUARDAR 
            Validaciones.LimpiarFormulario(flowLayoutPanel2);
        }

        private void BtnVerLista_Click(object sender, EventArgs e)
        {
            FrmListaColaboradores frmListaColaboradores = new FrmListaColaboradores();
            frmListaColaboradores.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //CODIGO PARA ACTUALIZAR AL FINAL OCULTAR LOS BOTONES DE NUEVO
            BtnModificar.Visible = false;
            BtnEliminar.Visible = false;
            BtnGuardarColaborador.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //CODIGO PARA Eliminar AL FINAL OCULTAR LOS BOTONES DE NUEVO
            BtnModificar.Visible = false;
            BtnEliminar.Visible = false;
            BtnGuardarColaborador.Enabled = true;
        }
    }
}
