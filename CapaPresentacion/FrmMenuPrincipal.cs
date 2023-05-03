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
    public partial class FrmMenuPrincipal : Form
    {
        //------------------------------------------------------------------------------------------
        //Aca se crea el metodo para abrir los formularios hijos
        #region Formulario Hijo
        private Form FormularioHijoActual;// 
        /// <summary>
        /// funcion para abrir formularios dentro de un formulario padre atraves de un panel contenedor
        /// </summary>
        /// <param name="FormularioHijo"></Resive como parametro un objeto de tipo formulario>
        public void AbrirFormularioHijo(Form FormularioHijo)
        {
            if (FormularioHijoActual != null)
            {
                // Para abrir un unico Formulario
                FormularioHijoActual.Close();
            }

            FormularioHijoActual = FormularioHijo;
            FormularioHijo.TopLevel = false; // indicacion que el formulario es de bajo nivel
            FormularioHijo.FormBorderStyle = FormBorderStyle.None; // eliminacion de los bordes al formulario
            FormularioHijo.Dock = DockStyle.Fill; // indicacion que abarque el tamaño total del panel contenedor
            PanelContenedor.Controls.Add(FormularioHijo);//incustracion del formulario al panel contenedor
            PanelContenedor.Tag = FormularioHijo;
            FormularioHijo.BringToFront(); // traemos al frente al formulario
            FormularioHijo.Show();//mostramos el Formulario
        }

        #endregion
        //------------------------------------------------------------------------------------------

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

            // Aca Generar las lineas de codigo para el respaldo de la base de datos



        }

        private void BtnAñadirProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAñadirProductos());
        }

        private void BtnColaboradores_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmColaboradores());
        }

        private void BtnGenerarCompras_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmSolicitudCompra());
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            if (FormularioHijoActual == null)
            {

                return;
            }
            else 
            {
                FormularioHijoActual.Close();

            }
        }

        private void BtnPresupuesto_Click(object sender, EventArgs e)
        {
            FrmPresupuesto frmPresupuesto = new FrmPresupuesto();
            frmPresupuesto.ShowDialog();
        }

        private void BtnSolicitud_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmSolicitudInsumos());
        }

        private void BtnHCompras_Click(object sender, EventArgs e)
        {
            FrmHistCompras histCompras = new FrmHistCompras();
            histCompras.ShowDialog();
        }

        private void BtnHInsumos_Click(object sender, EventArgs e)
        {
            FrmHistInsumos histInsumos = new FrmHistInsumos();
            histInsumos.ShowDialog();
        }
    }
}
