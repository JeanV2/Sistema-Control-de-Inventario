using Guna.UI2.WinForms;
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
    public partial class FrmPresupuesto : Form
    {
       


        public FrmPresupuesto()
        {
            InitializeComponent();
        }
      

private void BtnVerLista_Click(object sender, EventArgs e)
        {
            FrmListaPresupuestos frmListaPresupuestos = new FrmListaPresupuestos();
            frmListaPresupuestos.ShowDialog();
        }

        private void FrmPresupuesto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnGuardarPresupuesto_Click(object sender, EventArgs e)
        {
            if (TxtCodigoPresepuesto.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtCodigoPresepuesto);

                if (TxtMontuoProsupuesto.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtMontuoProsupuesto);

                    //------------------------------------------------------------------------------------------
                    // ACA VA EL CODIGO PARA REALIZAR EL GUARDADO



                    //------------------------------------------------------------------------------------------
                }
                else
                {
                    Validaciones.MostarError(TxtMontuoProsupuesto, "Debes ingresar el codigo del presupuesto");
                }
            }
            else
            {
                Validaciones.MostarError(TxtCodigoPresepuesto, "Debes ingresar el codigo del presupuesto");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TxtCodigoPresepuesto.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtCodigoPresepuesto);

                if (TxtMontuoProsupuesto.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtMontuoProsupuesto);

                    //------------------------------------------------------------------------------------------
                    // ACA VA EL CODIGO PARA REALIZAR LA MODIFICACION



                    //------------------------------------------------------------------------------------------
                }
                else
                {
                    Validaciones.MostarError(TxtMontuoProsupuesto, "Debes ingresar el codigo del presupuesto");
                }
            }
            else
            {
                Validaciones.MostarError(TxtCodigoPresepuesto, "Debes ingresar el codigo del presupuesto");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtCodigoPresepuesto.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtCodigoPresepuesto);

                if (TxtMontuoProsupuesto.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtMontuoProsupuesto);

                    //------------------------------------------------------------------------------------------
                    // ACA VA EL CODIGO PARA REALIZAR LA ELIMINACION



                    //------------------------------------------------------------------------------------------
                }
                else
                {
                    Validaciones.MostarError(TxtMontuoProsupuesto, "Debes ingresar el codigo del presupuesto");
                }
            }
            else
            {
                Validaciones.MostarError(TxtCodigoPresepuesto, "Debes ingresar el codigo del presupuesto");
            }
        }

        private void TxtCodigoPresepuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras_y_Numeros(e, TxtCodigoPresepuesto);
        }

        private void TxtMontuoProsupuesto_TextChanged(object sender, EventArgs e)
        {
            Validaciones.AgregarSimboloColones(TxtMontuoProsupuesto);
        }

        private void TxtMontuoProsupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_Decimales_y_Borrar(e, TxtMontuoProsupuesto);
        }
    }
}
