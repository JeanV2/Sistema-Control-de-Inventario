using CapaEntidades;
using CapaNegocios;
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
        NegocioPresupuestos NegocioPresupuestos = new NegocioPresupuestos();
        TbPresupuesto tbPresupuesto1 = new TbPresupuesto();
        public FrmPresupuesto()
        {
            InitializeComponent();
        }
      

        private void BtnVerLista_Click(object sender, EventArgs e)
        {
            FrmImportarExcelPresupuesto frmImportarExcel = new FrmImportarExcelPresupuesto();
            //frmImportarExcel.pasarDatosEvent += pasarDatosFormularios;
            frmImportarExcel.ShowDialog();
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

                if (TxtNombreProsupuesto.TextLength > 0)
                {
                    //Validaciones.LimpiarError(TxtMontuoProsupuesto);

                    //------------------------------------------------------------------------------------------
                    // ACA VA EL CODIGO PARA REALIZAR EL GUARDADO

                    TbPresupuesto tbPresupuesto = new TbPresupuesto();

                    //Llenamos el presupuesto
                    //tbPresupuesto.IdPresupuesto = TxtCodigoPresepuesto.Text;
                    ////tbPresupuesto.MesPresupuesto = DtpFechaSolicitud.Value;
                    //tbPresupuesto.MontoPresupuesto = Convert.ToDouble(TxtNombreProsupuesto.Text);
                    //tbPresupuesto.EstadoPresupuesto = true;

                    if (NegocioPresupuestos.GuardarPresupuesto(tbPresupuesto))
                    {
                        MessageBox.Show("Presupuesto agregado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al Guardar", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //------------------------------------------------------------------------------------------
                }
                else
                {
                    Validaciones.MostarError(TxtNombreProsupuesto, "Debes ingresar el codigo del presupuesto");
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

                if (TxtNombreProsupuesto.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtNombreProsupuesto);

                    //------------------------------------------------------------------------------------------
                    // ACA VA EL CODIGO PARA REALIZAR LA MODIFICACION

                    //modificar(tbPresupuesto1.EstadoPresupuesto == true);

                    //------------------------------------------------------------------------------------------
                }
                else
                {
                    Validaciones.MostarError(TxtNombreProsupuesto, "Debes ingresar el codigo del presupuesto");
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

                if (TxtNombreProsupuesto.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtNombreProsupuesto);

                    //------------------------------------------------------------------------------------------
                    // ACA VA EL CODIGO PARA REALIZAR LA ELIMINACION

                    DialogResult dialog = MessageBox.Show("Estas seguro de eliminar este presupuesto", "Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                    if (dialog == DialogResult.Yes)
                    {
                        //tbPresupuesto1.EstadoPresupuesto = false;
                        if (NegocioPresupuestos.EliminarPresupuesto(tbPresupuesto1))
                        {
                            MessageBox.Show("Presupuesto eliminado", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            //restablecer();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //restablecer();
                    //------------------------------------------------------------------------------------------
                }
                else
                {
                    Validaciones.MostarError(TxtNombreProsupuesto, "Debes ingresar el codigo del presupuesto");
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
            Validaciones.AgregarSimboloColones(TxtNombreProsupuesto);
        }

        private void TxtMontuoProsupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_Decimales_y_Borrar(e, TxtNombreProsupuesto);
        }

        //private string ObtenerCodigo()
        //{
        //    String Codigo = "";

        //    NegocioPresupuestos negocio = new NegocioPresupuestos();
        //    List<TbPresupuesto> lista = negocio.ListaPresupuestos();
        //    TbPresupuesto TbPresupuestos = new TbPresupuesto();

        //    TbPresupuestos = lista.LastOrDefault();

        //    if (lista.Count() > 0)
        //    {
        //        if ((int.Parse(TbPresupuestos.IdPresupuesto) + 1) > 9)
        //        {
        //            Codigo = "0000" + (int.Parse(TbPresupuestos.IdPresupuesto) + 1).ToString();
        //            if ((int.Parse(TbPresupuestos.IdPresupuesto) + 1) > 99)
        //            {
        //                Codigo = "000" + (int.Parse(TbPresupuestos.IdPresupuesto) + 1).ToString();
        //            }
        //            else
        //            {
        //                Codigo = "0000" + (int.Parse(TbPresupuestos.IdPresupuesto) + 1).ToString();
        //            }
        //        }
        //        else
        //        {
        //            Codigo = "00000" + (int.Parse(TbPresupuestos.IdPresupuesto) + 1).ToString();
        //        }
        //    }
        //    else
        //    {
        //        Codigo = "0000";
        //    }
        //    return Codigo;
        }

        //private void FrmPresupuesto_Load(object sender, EventArgs e)
        //{
        //    //TxtCodigoPresepuesto.Text = ObtenerCodigo();
        //}

        //public void CargarDatosFormulario(TbPresupuesto presupuesto)
        //{
        //    //TxtCodigoPresepuesto.Text = presupuesto.IdPresupuesto;
        //    //TxtNombreProsupuesto.Text = presupuesto.MontoPresupuesto.ToString();
        //    ////DtpFechaSolicitud.Text = presupuesto.MesPresupuesto.ToString();
        //}

        //private void pasarDatosFormularios(TbPresupuesto _presupuesto)
        //{
        //    tbPresupuesto1 = _presupuesto;
        //    CargarDatosFormulario(tbPresupuesto1);
        //    BtnModificar.Visible = true;
        //    BtnEliminar.Visible = true;
        //    BtnGuardarPresupuesto.Visible = false;
        //    TxtCodigoPresepuesto.Enabled = false;
        //}
        //private void restablecer()
        //{
        //    TxtCodigoPresepuesto.Enabled = true;
        //    BtnEliminar.Visible = false;
        //    BtnModificar.Visible = false;
        //    BtnGuardarPresupuesto.Visible = true;
        //}

        //public void modificarDatos(bool estado)
        //{
        //    if (estado)
        //    {
        //        tbPresupuesto1.MontoPresupuesto = double.Parse(TxtNombreProsupuesto.Text);
        //        //tbPresupuesto1.MesPresupuesto = DtpFechaSolicitud.Value;
        //    }
        //    ////tbPresupuesto1.EstadoPresupuesto = true;
        //}
        //public void modificar(bool estado)
        //{
        //    modificarDatos(estado);
        //    if(NegocioPresupuestos.EditarPresupuesto(tbPresupuesto1))
        //    {
        //        MessageBox.Show("Presupuesto modificado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
        //        restablecer();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error al modificar");
        //    }
        //}
    }

